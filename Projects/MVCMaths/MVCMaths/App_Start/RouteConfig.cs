using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCMaths
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "ProcessData",
               url: "Math/ProcessData",
               defaults: new { controller = "Math", action = "Calculation", id = UrlParameter.Optional }
           );

            routes.MapRoute(
              name: "ProcessData1",
              url: "ProcessData",
              defaults: new { controller = "Math", action = "Calculation", id = UrlParameter.Optional }
          );

            routes.MapRoute(
                name: "Addition",
                url: "Add/{a}/{b}",
                defaults: new { controller = "Math", action = "Add", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Subtract",
                url: "Sub/{a}/{b}",
                defaults: new { controller = "Math", action = "Subtract", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Multiply",
                url: "Mul/{a}/{b}",
                defaults: new { controller = "Math", action = "Multiply", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Divide",
                url: "Div/{a}/{b}",
                defaults: new { controller = "Math", action = "Division", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Default1",
               url: "{controller}/{action}/{id}",
               defaults: new { controller = "Math", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
