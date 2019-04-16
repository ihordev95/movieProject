using System.Web.Mvc;
using System.Web.Http;
namespace Team3_Project {
	public class RouteConfig {
		public static void RegisterRoutes(System.Web.Routing.RouteCollection routes) {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.MapRoute(
				name: "Default" ,
				url: "{controller}/{action}/{id}" ,
				defaults: new { controller = "Landing" , action = "Index" , id = System.Web.Mvc.UrlParameter.Optional }
			);
		}
	}
}
