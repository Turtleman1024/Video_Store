using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DinoVideo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            //Example of Attribute routing made simpler
            routes.MapMvcAttributeRoutes();

            //Example of a custom route with three parameters
            //Most go before default as the order matters
            //Define most specific to most generic
            //"/movies/released/2015/04"
            //routes.MapRoute(
            //    //Route Name should be unique
            //    "MoviesByReleaseDate",
            //    //URL Pattern
            //    "movies/released/{year}/{month}",
            //    //Use a generic anonymous object
            //    new { controller = "Movies", action = "ByReleaseDate"},
            //    //Make the year have to be four digits and month two digits
            //    new { year = @"\d{4}", month = @"\d{2}" }
            //    //Place a contrant on the year to be 2015 or 2016
            //    //new { year = @"2015|2016", month = @"\d{2}" }
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
