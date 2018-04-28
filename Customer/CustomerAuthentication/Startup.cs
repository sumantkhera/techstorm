using CustomerAuthentication.Format;
using CustomerAuthentication.Providers;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Configuration;
using System.Web.Http;

[assembly: OwinStartup(typeof(CustomerAuthentication.Startup))]
namespace CustomerAuthentication
{
    /// <summary>
    /// Start up Classes
    /// </summary>
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            HttpConfiguration config = new HttpConfiguration();
            ConfigureOAuth(app);
            //Rest of code is here;
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            string TokenExpireTime = ConfigurationManager.AppSettings["AccessTokenLifeSpanMinutes"] != null ? ConfigurationManager.AppSettings["AccessTokenLifeSpanMinutes"] : "30";
            string Issuer = ConfigurationManager.AppSettings["Issuer"] != null ? ConfigurationManager.AppSettings["Issuer"] : "AAPRYL.Auth";
            var oauthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/Login"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(int.Parse(TokenExpireTime)),
                Provider = new SimpleAuthorizationServerProvider(),
                AccessTokenFormat = new CustomJwtFormat(ConfigurationManager.AppSettings["Issuer"]),
                RefreshTokenProvider = new RefreshTokenProvider()
            };
            app.UseOAuthAuthorizationServer(oauthServerOptions);

            /***********Code is used to authorized user while logout********************************/
            var issuer = ConfigurationManager.AppSettings["Issuer"];
            var audience = ConfigurationManager.AppSettings["Audience"];
            var secret = Microsoft.Owin.Security.DataHandler.Encoder.TextEncodings.Base64Url.Decode(ConfigurationManager.AppSettings["Secret"]);

            // Api controllers with an [Authorize] attribute will be validated with JWT
            app.UseJwtBearerAuthentication(
                new Microsoft.Owin.Security.Jwt.JwtBearerAuthenticationOptions
                {
                    AuthenticationMode = AuthenticationMode.Active,
                    AllowedAudiences = new[] { audience },
                    IssuerSecurityTokenProviders = new Microsoft.Owin.Security.Jwt.IIssuerSecurityTokenProvider[]
                    {
                        new Microsoft.Owin.Security.Jwt.SymmetricKeyIssuerSecurityTokenProvider(issuer, secret)
                    }
                });
        }

    }
    
    
    
}