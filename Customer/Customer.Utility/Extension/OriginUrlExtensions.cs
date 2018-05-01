using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Utility.Extension
{
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
