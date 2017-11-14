using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using Fifa.Proclube.API.App_Start;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Fifa.Proclube.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
           


            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Formatters.JsonFormatter.SerializerSettings.Re‌​ferenceLoopHandling = ReferenceLoopHandling.Ignore;

            config.Formatters.Remove(config.Formatters.XmlFormatter);

        }
    }
}
