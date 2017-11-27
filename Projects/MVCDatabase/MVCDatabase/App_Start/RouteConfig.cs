using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCDatabase
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Start",
               url: "",
               defaults: new { controller = "Bank", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "New",
                url: "new",
                defaults: new { controller = "Bank", action = "New", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "AddNew",
                url: "Process",
                defaults: new { controller = "Bank", action = "AddNew", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Delete",
               url: "Delete/{PId}",
               defaults: new { controller = "Bank", action = "Delete", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Edit",
               url: "Edit/{PId}",
               defaults: new { controller = "Bank", action = "Edit", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Update",
               url: "EditProcess/{PId}",
               defaults: new { controller = "Bank", action = "Update", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
