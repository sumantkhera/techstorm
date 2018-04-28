using Database.Context;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler.Encoder;
using System;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.Linq;
using Thinktecture.IdentityModel.Tokens;

namespace CustomerAuthentication.Format
{
    /// <summary>
    /// Customer jwt format class.
    /// </summary>
    public class CustomJwtFormat : ISecureDataFormat<AuthenticationTicket>
    {
        private readonly string _issuer;

        public CustomJwtFormat(string issuer)
        {
            _issuer = issuer;
        }

        /// <summary>
        /// Implement the secure data
        /// </summary>
        /// <param name="data">Ticket detail.</param>
        /// <returns>Jwt token</returns>
        public string Protect(AuthenticationTicket data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            var audienceId = data.Properties.Dictionary.ContainsKey("audience") ? data.Properties.Dictionary["audience"] : null;

            if (string.IsNullOrWhiteSpace(audienceId)) throw new InvalidOperationException("AuthenticationTicket.Properties does not include audience");

            using (var dbcontext = new DatabaseContext())
            {

                string symmetricKeyAsBase64 = ConfigurationManager.AppSettings["Secret"];// "FkbU1pqkgbb3_e90j35Uo5rQG95zIDgbr4AoTvITaKI";

                var keyByteArray = TextEncodings.Base64Url.Decode(symmetricKeyAsBase64);

                var signingKey = new HmacSigningCredentials(keyByteArray);

                var issued = data.Properties.IssuedUtc;
                var expires = data.Properties.ExpiresUtc;
                var expireTime = data.Properties.Dictionary.ContainsKey("expires") ? data.Properties.Dictionary["expires"] : null;
                if (!string.IsNullOrEmpty(expireTime))
                {
                    expires = data.Properties.IssuedUtc.Value.AddMinutes(int.Parse(expireTime));
                }
                var token = new JwtSecurityToken(_issuer, audienceId, data.Identity.Claims, issued.Value.UtcDateTime, expires.Value.UtcDateTime, signingKey);

                var handler = new JwtSecurityTokenHandler();

                var jwt = handler.WriteToken(token);
                string userName = data.Properties.Dictionary.ContainsKey("username") ? data.Properties.Dictionary["username"] : null;
                if (!string.IsNullOrWhiteSpace(userName))
                {
                    var user = dbcontext.Users.Where(m => m.UserName == userName).FirstOrDefault();
                    if (user != null && !string.IsNullOrEmpty(user.Token)) //&& m.ExpiryDate > DateTime.UtcNow
                    {
                        jwt = user.Token;
                    }
                    else
                    {
                        user.Token = jwt;
                        dbcontext.SaveChangesAsync();
                    }
                }
                string val;
                if (data.Properties.Dictionary.TryGetValue("jwtToken", out val))
                {
                    data.Properties.Dictionary["jwtToken"] = jwt;
                }
                else
                {
                    data.Properties.Dictionary.Add("jwtToken", jwt);
                }

                return jwt;
            }

        }

        /// <summary>
        /// Default method
        /// </summary>
        /// <param name="protectedText"></param>
        /// <returns></returns>
        public AuthenticationTicket Unprotect(string protectedText)
        {
            throw new NotImplementedException();
        }
    }
}