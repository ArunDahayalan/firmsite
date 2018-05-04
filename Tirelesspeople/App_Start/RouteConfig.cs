using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Tirelesspeople
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

          //  routes.MapRoute(
          //    "CompanyBlog",
          //    "blog",
          //    new { controller = "Blog", action = "BlogHome" }
          //);

            routes.MapRoute(
               "CompanyBlogPage",
               "companyblog",
               new { controller = "Blog", action = "Index" }
           );

            routes.MapRoute(
               "CompanyPortfolio",
               "portfolio",
               new { controller = "Portfolio", action = "Index" }
           );
            routes.MapRoute(
               "CompanyProducts",
               "products",
               new { controller = "Products", action = "Index" }
           );
            routes.MapRoute(
             "CompanyServices",
             "services",
             new { controller = "Services", action = "Index" }
         );

            routes.MapRoute(
               "CompanyAboutus",
               "aboutus",
               new { controller = "Company", action = "Aboutus" }
           );
            routes.MapRoute(
               "CompanyContactus",
               "contactus",
               new { controller = "Company", action = "Contactus" }
           );

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
