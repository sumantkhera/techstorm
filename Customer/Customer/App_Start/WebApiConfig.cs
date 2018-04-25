using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Customer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            var corsAttr = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(corsAttr);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            //By default Web API return XML data
            //We can remove this by clearing the SupportedMediaTypes option as follows
            config.Formatters.XmlFormatter.SupportedMediaTypes.Clear();

            //Now set the serializer setting for JsonFormatter to Indented to get Json Formatted data
            config.Formatters.JsonFormatter.SerializerSettings.Formatting =
                Newtonsoft.Json.Formatting.Indented;

            //For converting data in Camel Case
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver =new CamelCasePropertyNamesContractResolver();

            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);

            //json.Serialivar corsAttr = new EnableCorsAttribute("*", "*", "*");
            //config.EnableCors(corsAttr);
            //config.MapHttpAttributeRoutes();

        }
    }
}
