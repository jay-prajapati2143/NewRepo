using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StackOverFlow
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Test",
            //    url: "Test/{controller}",
            //    defaults: new { controller = "Test", action = "Identity", id = UrlParameter.Optional }
            //    );

            //routes.MapRoute(
            //    name: "Test",
            //    url: "Test/NonIdentity",
            //    defaults: new { controller = "Test", action = "Identity", id = UrlParameter.Optional }
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
