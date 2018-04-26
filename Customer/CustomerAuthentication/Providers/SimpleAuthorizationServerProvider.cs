using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.OAuth;
using Database.Context;
using System.IO;
using System.Configuration;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using System.Net.Http;
using System.Text.RegularExpressions;

namespace CustomerAuthentication.Providers
{
    public class SimpleAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        /// <summary>
        /// Validate client authentication
        /// </summary>
        /// <param name="context">Client authentication context</param>
        /// <returns> Not retuning any value</returns>
        public override Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Request.Body.Position = 0;
            var body = HttpUtility.UrlDecode(new StreamReader(context.Request.Body).ReadToEnd());
            if (StringHtmlUtilities.StringContainsHtmlTags(body) || context.Request.Headers.Any(h => h.Value.Any(StringHtmlUtilities.StringContainsHtmlTags)))
            {
                context.SetError("invalid_request", $"Request contains invalid data.");
                return Task.FromResult<object>(null);
            }
            //// Get audience from paramaters
            var audienceId = ConfigurationManager.AppSettings["Audience"];
            context.OwinContext.Set("as:audienceId", audienceId);
            context.Validated();
            return Task.FromResult<object>(null);
        }

        /// <summary>
        /// GrantResourceOwnerCredentials: Function is used to validate the user. 
        /// If not a valid user then raise a invalid credential error 
        /// </summary>
        /// <param name="context">Contains owner credential context</param>
        /// <returns>Not returning any values</returns>
        public override Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            using (var dbcontext = new DatabaseContext())
            {
                var origin = context.Request.GetOriginUrl();

                //TODO: CONFLICITING WITH CORS
                /*if (origin != null)
                {
                    if (context.OwinContext.Response.Headers["Access-Control-Allow-Origin"] != null)
                        context.OwinContext.Response.Headers.Set("Access-Control-Allow-Origin", origin);
                    else
                        context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { origin });
                }*/
                //// check the validity of the user. if it is not exist then raise an error.
                var user = dbcontext.Users.SingleOrDefault(m => m.UserName == context.UserName && m.IsDeleted == false);

                if (user == null)
                {
                    context.SetError("invalid_grant", "The user name or password is incorrect");
                    return Task.FromResult<object>(null);
                }

                {
                    var identity = new ClaimsIdentity("JWT");

                    ////Set all the claimes for the particular user.
                    identity.AddClaim(new Claim("grant", "UserName"));
                    identity.AddClaim(new Claim(ClaimTypes.Name, user.UserId.ToString()));
                    identity.AddClaim(new Claim("userName", user.UserName));
                    identity.AddClaim(new Claim("sub", context.UserName));
                    identity.AddClaim(new Claim("userId", user.UserId.ToString()));
                    identity.AddClaim(new Claim("licenseeId", "126"));

                    if (origin != null)
                    {
                        identity.AddClaim(new Claim("origin", origin));
                    }

                    var audienceId = context.OwinContext.Get<string>("as:audienceId");
                    context.OwinContext.Set("as:userName", context.UserName);
                    context.OwinContext.Set("as:userId", user.UserId.ToString());
                    context.OwinContext.Set("as:isAdmin", "0");

                    var props = new AuthenticationProperties(new Dictionary<string, string>
                    {
                        { "audience", audienceId },
                        { "username", context.UserName },
                        { "grant", "password" },
                        { "expires", "15265" }
                    });

                    var ticket = new AuthenticationTicket(identity, props);
                    context.Validated(ticket);
                    return Task.FromResult<object>(null);
                }
            }
        }

        /// <summary>
        /// Used to set the token end points. we have to set four extra attributes in responce.
        /// </summary>
        /// <param name="context">Token endpoint </param>
        /// <returns>Returning result</returns>
        public override Task TokenEndpoint(OAuthTokenEndpointContext context)
        {
            var userName = context.OwinContext.Get<string>("as:userName");
            var userId = context.OwinContext.Get<string>("as:userId");
            var isAdmin = context.OwinContext.Get<string>("as:isAdmin");

            context.AdditionalResponseParameters.Add("user_id", userId);
            context.AdditionalResponseParameters.Add("user_name", userName);
            context.AdditionalResponseParameters.Add("isAdmin", isAdmin);
            context.AdditionalResponseParameters.Add("issued_on", context.Properties.IssuedUtc);
            context.AdditionalResponseParameters.Add("expire_on", context.Properties.ExpiresUtc);
            return Task.FromResult<object>(null);
        }

        /// <summary>
        /// Used to refresh token 
        /// </summary>
        /// <param name="context">Refresh token context</param>
        /// <returns>Returning result</returns>
        public override Task GrantRefreshToken(OAuthGrantRefreshTokenContext context)
        {
            //// Check if the user gets inactive after login then it will raise an error.
            using (var dbcontext = new DatabaseContext())
            {
                string userName = context.Ticket.Properties.Dictionary["username"];
                var user = dbcontext.Users.SingleOrDefault(m => m.UserName == userName && m.IsDeleted == false);
                if (user == null)
                {
                    context.Rejected();
                    context.SetError("invalid_user", "This is not a valid user.");
                    return Task.FromResult<object>(null);
                }
            }

            var newIdentity = new ClaimsIdentity(context.Ticket.Identity);
            var newTicket = new AuthenticationTicket(newIdentity, context.Ticket.Properties);
            context.Validated(newTicket);
            return Task.FromResult<object>(null);
        }

        /// <summary>
        /// MatchEndpoint
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override Task MatchEndpoint(OAuthMatchEndpointContext context)
        {
            if (context.OwinContext.Request.Method == "OPTIONS" && context.IsTokenEndpoint)
            {
                context.OwinContext.Response.StatusCode = 200;
                //context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
                //context.OwinContext.Response.Headers.Add("Access-Control-Allow-Methods", new[] { "POST" });
                //context.OwinContext.Response.Headers.Add("Access-Control-Allow-Headers", new[] { "accept", "authorization", "content-type" });                
                context.RequestCompleted();

                return Task.FromResult<object>(null);
            }
            return base.MatchEndpoint(context);
        }

    }
    public static class StringHtmlUtilities
    {
        private static string _htmlTags =
            "!DOCTYPE|a|abbr|acronym|address|applet|area|article|aside|audio|b|base|basefont|bdi|bdo|big|blockquote|body|br|button|canvas|caption|center|cite|code|col|colgroup|command|datalist|dd|del|details|dfn|dir|div|dl|dt|em|embed|fieldset|figcaption|figure|font|footer|form|frame|frameset|h1|h2|h3|h4|h6|h6|head|header|hgroup|hr|html|i|iframe|img|input|ins|kbd|keygen|label|legend|li|link|map|mark|menu|meta|meter|nav|noframes|noscript|object|ol|optgroup|option|output|p|param|pre|progress|q|rp|rt|ruby|s|samp|script|section|select|small|source|span|strike|strong|style|sub|summary|sup|table|tbody|td|textarea|tfoot|th|thead|time|title|tr|track|tt|u|ul|var|video|wbr|abbr|object";


        public static bool StringContainsHtmlTags(string str)
        {
            return Regex.IsMatch(str, $@"(?s)<\s?({_htmlTags}).*?", RegexOptions.IgnoreCase);
        }
        public static string RemoveHtml(string text)
        {
            var first = Regex.Replace(text, @"<(" + _htmlTags + @").*</(" + _htmlTags + @")>", string.Empty, RegexOptions.IgnoreCase);
            var second = Regex.Replace(first, @"</(" + _htmlTags + @")*?>", string.Empty, RegexOptions.IgnoreCase);

            return Regex.Replace(second, @"<(" + _htmlTags + @").*(</(" + _htmlTags + @")>)?", string.Empty, RegexOptions.IgnoreCase);
        }
    }

    public static class OriginUrlExtensions
    {
        public static string GetOriginUrl(this IOwinRequest request)
        {
            if (request?.Headers == null) return null;

            var origin = request.Headers["Origin"];
            var referer = request.Headers["Referer"];

            if (origin == null && referer == null) return null;
            var requestUri = new Uri(origin ?? referer);
            var requestOrigin = requestUri.Scheme + "://" + requestUri.Host + (requestUri.Port > 0 && requestUri.Port != 80 && requestUri.Port != 443 ? ":" + requestUri.Port : string.Empty);
            return requestOrigin;
        }

        /// <summary>
        /// OriginUrlExtensions: Function is used to test the current origin of the request
        /// </summary>
        /// <param name="request">extention method of HttpRequestMessage</param>
        /// <returns></returns>
        public static string GetOriginUrl(this HttpRequestMessage request)
        {
            if (request?.Headers == null) return null;

            var origin = request.Headers.Contains("Origin") ? request.Headers.FirstOrDefault(h => h.Key == "Origin").Value.FirstOrDefault() : null;
            var referer = request.Headers.Referrer;

            if (origin == null && referer == null) return null;
            var requestUri = origin != null ? new Uri(origin) : referer;
            var requestOrigin = requestUri.Scheme + "://" + requestUri.Host + (requestUri.Port > 0 && requestUri.Port != 80 && requestUri.Port != 443 ? ":" + requestUri.Port : string.Empty);
            return requestOrigin;
        }

    }
}
