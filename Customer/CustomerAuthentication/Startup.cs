using CustomerAuthentication.Providers;
using Microsoft.Owin;
using Microsoft.Owin.Security.Infrastructure;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Microsoft.Owin.Security.DataHandler.Encoder;
using Database.Context;

[assembly: OwinStartup(typeof(CustomerAuthentication.Startup))]
namespace CustomerAuthentication
{
    public class Startup
    {
        //public void Configuration(IAppBuilder app)
        //{
        //	HttpConfiguration config = new HttpConfiguration();
        //	WebApiConfig.Register(config);
        //	app.UseWebApi(config);
        //}

        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();
            ConfigureOAuth(app);
            //Rest of code is here;
            WebApiConfig.Register(config);
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            //app.UseWebApi(config);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromDays(1),
                Provider = new SimpleAuthorizationServerProvider(),
                RefreshTokenProvider = new RefreshTokenProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }

    }
    public class RefreshTokenProvider : IAuthenticationTokenProvider
    {
        /// <summary>
        /// Create refresh token entry in DB
        /// </summary>
        /// <param name="context">Authentication Token CreateContext </param>
        /// <returns>Not returning any thing</returns>
        public async Task CreateAsync(AuthenticationTokenCreateContext context)
        {
            var grant = context.Request.Headers["grant"];

            if (string.IsNullOrEmpty(grant))
            {
                return;
            }

            var refreshTokenId = ApiKeyProvider.GenerateKey();
            context.Ticket.Properties.Dictionary.Remove("jwtToken");
            if (grant == "password")
            {
                var username = context.Request.Headers["username"];
                using (var dbcontext = new DatabaseContext())
                {
                    var user = dbcontext.Users.Where(p => p.UserName == username).FirstOrDefault();

                    if (user != null)
                    {
                        user.Token = refreshTokenId;
                        user.ModifyOn = DateTime.Now;
                        await dbcontext.SaveChangesAsync();
                    }
                }
                context.SetToken(refreshTokenId);
            }
        }

        /// <summary>
        /// ReceiveAsync: Called for refresh the token
        /// </summary>
        /// <param name="context">Token receive context</param>
        /// <returns> Not returning any value</returns>
        public async Task ReceiveAsync(AuthenticationTokenReceiveContext context)
        {

        }

        /// <summary>
        /// Create: Not implemented
        /// </summary>
        /// <param name="context">AuthenticationTokenCreateContext parameter</param>
        public void Create(AuthenticationTokenCreateContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Receive  Not implemented
        /// </summary>
        /// <param name="context">AuthenticationTokenReceiveContext parameter</param>
        public void Receive(AuthenticationTokenReceiveContext context)
        {
            throw new NotImplementedException();
        }
    }
    public static class ApiKeyProvider
    {
        /// <summary>
        /// GenerateKey: used to create a unique key
        /// </summary>
        /// <returns>return base64 encoded key</returns>
        public static string GenerateKey()
        {
            var key = new byte[32];
            RNGCryptoServiceProvider.Create().GetBytes(key);
            var base64Secret = TextEncodings.Base64Url.Encode(key);

            return base64Secret;
        }
    }
}