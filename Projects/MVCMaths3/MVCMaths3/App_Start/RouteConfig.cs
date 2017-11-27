using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCMaths3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Addition",
                url: "Addition",
                defaults: new { controller = "Maths", action = "Add", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Subtraction",
                url: "Subtraction",
                defaults: new { controller = "Maths", action = "Sub", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Multiplication",
                url: "Multiplication",
                defaults: new { controller = "Maths", action = "Mul", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Division",
                url: "Division",
                defaults: new { controller = "Maths", action = "Div", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Operation",
                url: "Operation",
                defaults: new { controller = "Operation", action = "Operation", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Start",
                url: "",
                defaults: new { controller = "Maths", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
