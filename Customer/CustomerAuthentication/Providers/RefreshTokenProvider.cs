using Microsoft.Owin.Security.Infrastructure;
using System;
using System.Threading.Tasks;

namespace CustomerAuthentication.Providers
{
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
}