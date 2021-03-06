﻿using System;
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
                    httpMethod = new HttpMethodConstraint("GET")
                }
            );

            routes.MapRoute(
                name: "Search",
                url: "search/",
                defaults: new {
                    controller = "SearchItems",
                    action = "Index",
                    httpMethod = new HttpMethodConstraint("GET")
                }
            );

            routes.MapRoute(
                name: "Item",
                url: "item/{id}/",
                defaults: new {
                    controller = "Item",
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

            routes.MapRoute(
                name: "Logout",
                url: "logout/",
                defaults: new {
                    controller = "Account",
                    action = "Logout",
                    httpMethod = new HttpMethodConstraint("GET")
                }
            );

            routes.MapRoute(
                name: "Profile",
                url: "profile/",
                defaults: new {
                    controller = "Account",
                    action = "Profile",
                    httpMethod = new HttpMethodConstraint("GET")
                }
            );

            routes.MapRoute(
                name: "AdminPanel",
                url: "adminpanel/",
                defaults: new {
                    controller = "Account",
                    action = "AdminPanel",
                    httpMethod = new HttpMethodConstraint("GET")
                }
            );

            routes.MapRoute(
                name: "Stations",
                url: "stations/",
                defaults: new {
                    controller = "StaticContent",
                    action = "Stations",
                    httpMethod = new HttpMethodConstraint("GET")
                }
            );

            routes.MapRoute(
                name: "AddItem",
                url: "additem/{id}/",
                defaults: new {
                    controller = "AddItem",
                    id = UrlParameter.Optional,
                    action = "Index",
                    httpMethod = new HttpMethodConstraint("GET")
                }
            );
        }
    }
}
