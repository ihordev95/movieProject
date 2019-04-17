using System.Web.Http;
namespace Team3_Project {
	public static class WebApiConfig {
		public static void Register(System.Web.Http.HttpConfiguration config) {
			config.MapHttpAttributeRoutes();
			config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/html"));
			config.Routes.MapHttpRoute(
				name: "DefaultApi" ,
				routeTemplate: "api/{controller}/{id}" ,
				defaults: new { id = System.Web.Http.RouteParameter.Optional }
			);
		}
	}
}