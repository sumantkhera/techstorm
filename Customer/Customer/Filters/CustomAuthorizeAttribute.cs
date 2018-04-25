using Customer.BusinessEntities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace Customer.Filters
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {        /// <summary>
             /// OnAuthorization: Custume authorization to check the validity of taken
             /// Set thread current principal
             /// </summary>
             /// <param name="actionContext"></param>
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            Task<string> content = actionContext.Request.Content.ReadAsStringAsync();
            string body = string.Empty;
            var request = new { Description = string.Empty, method = actionContext.Request.Method.ToString(), url = actionContext.Request.RequestUri, Header = actionContext.Request.Headers };
            try
            {
                body = content.Result;
                var identity = FetchFromHeader(actionContext);
                Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity("test"), null);

                //IRefreshTokenBL _refreshTokenBL = new RefreshTokenBL();
                //if (!_refreshTokenBL.IsTokenExist(actionContext.Request.Headers.Authorization.Parameter))
                //{
                //    request = new { Description = "Unathorized Request", method = actionContext.Request.Method.ToString(), url = actionContext.Request.RequestUri, Header = actionContext.Request.Headers };
                //    actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
                //}
                //var principal = actionContext.RequestContext.Principal as ClaimsPrincipal;
                //Thread.CurrentPrincipal = new CustomIdentity(principal);

                /***********Logging*******************************/

                base.OnAuthorization(actionContext);
            }
            catch (Exception ex)
            {
                request = new { Description = "Unathorized Request", method = actionContext.Request.Method.ToString(), url = actionContext.Request.RequestUri, Header = actionContext.Request.Headers };
                actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            }
        }

        private object FetchFromHeader(HttpActionContext actionContext)
        {
            string requestToken = null;

            var authRequest = actionContext.Request.Headers.Authorization;
            if (authRequest != null && !string.IsNullOrEmpty(authRequest.Scheme) && authRequest.Scheme == "Basic")
                requestToken = authRequest.Parameter;

            return requestToken;
        }
    }
}