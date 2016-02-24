using Microsoft.Owin;
using Owin;
using System.Web.Http;
using WebApiContrib.Formatting.Html;
using WebApiContrib.Formatting.Html.Formatting;
using WebApiContrib.Formatting.Razor;

namespace OwinSelfhostSample
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
                 
            GlobalViews.DefaultViewParser = new RazorViewParser();
            GlobalViews.DefaultViewLocator = new RazorViewLocator();


            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            config.Formatters.Add(new HtmlMediaTypeViewFormatter());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            appBuilder.UseWebApi(config);
        }
    }
}