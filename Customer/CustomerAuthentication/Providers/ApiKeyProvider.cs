using Microsoft.Owin.Security.DataHandler.Encoder;
using System.Security.Cryptography;

namespace CustomerAuthentication.Providers
{
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