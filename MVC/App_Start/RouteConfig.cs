using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Office",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Office", action = "Office", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Employee",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employee", action = "Create", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Employee1",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Employee", action = "View", id = UrlParameter.Optional }
            );
        }
    }
}
