using Owin;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Http;

namespace OsdDisplay.Host
{
    public class Startup
    {
        // This code configures Web API. The Startup class is specified as a type
        // parameter in the WebApp.Start method.
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                name: "Default",
                routeTemplate: "api/{action}",
                defaults: new { controller = "Display" }
            );

            appBuilder.UseWebApi(config);
        }
    }
}
