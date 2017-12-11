using Newtonsoft.Json;
using System.Web.Http;
using System.Web.Http.Cors;
using Newtonsoft.Json.Serialization;


namespace Legato.Service
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}"
            );

            config.EnableCors(new EnableCorsAttribute("*", "Accept, Content-Type, Origin, Authorization", "GET, POST, DELETE, OPTIONS"));

            config.Formatters.JsonFormatter.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
