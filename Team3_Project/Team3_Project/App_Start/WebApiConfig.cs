using System.Web.Http;
namespace Team3_Project {
	public static class WebApiConfig {
		public static void Register(System.Web.Http.HttpConfiguration config) {
			config.MapHttpAttributeRoutes();
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(new System.Net.Http.Formatting.RequestHeaderMapping("Accept","text/html",
                              System.StringComparison.InvariantCultureIgnoreCase,
                              true,
                              "application/json"));
            config.Routes.MapHttpRoute(
				name: "DefaultApi" ,
				routeTemplate: "api/{controller}/{id}" ,
				defaults: new { id = System.Web.Http.RouteParameter.Optional }
			);
		}
	}
}