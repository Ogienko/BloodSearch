using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web {
    public class RouteConfig {
        public static void RegisterRoutes(RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MainPage",
                url: "",
                defaults: new {
                    controller = "MainPage",
                    action = "Index",
                    httpMethod = new HttpMethodConstraint("GET") }
            );

            routes.MapRoute(
                name: "Search",
                url: "search/",
                defaults: new {
                    controller = "Search",
                    action = "Index",
                    httpMethod = new HttpMethodConstraint("GET")
                }
            );

            routes.MapRoute(
                name: "Registration",
                url: "registration/",
                defaults: new {
                    controller = "Account",
                    action = "Registration",
                    httpMethod = new HttpMethodConstraint("GET")
                }
            );

            routes.MapRoute(
                name: "Login",
                url: "login/",
                defaults: new {
                    controller = "Account",
                    action = "Login",
                    httpMethod = new HttpMethodConstraint("GET")
                }
            );
        }
    }
}
