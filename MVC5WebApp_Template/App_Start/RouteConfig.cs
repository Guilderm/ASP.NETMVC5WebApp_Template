using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5WebApp_Template
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new {controller = "Main", action = "FrontPage", id = UrlParameter.Optional}
            );
        }
    }
}