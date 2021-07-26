using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HospitalApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Staff",
                url: "staff",
                defaults: new { controller = "Staffs", action = "Index",id = UrlParameter.Optional});

            routes.MapRoute(
                name: "Patient",
                url: "patients",
                defaults: new { controller = "Patients", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Department",
                url: "departments",
                defaults: new { controller = "Departments", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Treatment",
                url: "treatment",
                defaults: new { controller = "Treatments", action = "Index", id = UrlParameter.Optional });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
