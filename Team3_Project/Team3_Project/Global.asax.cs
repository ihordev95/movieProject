namespace Team3_Project {
	public class MvcApplication : System.Web.HttpApplication {
		protected void Application_Start() {
			System.Web.Mvc.AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(System.Web.Mvc.GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(System.Web.Routing.RouteTable.Routes);
			BundleConfig.RegisterBundles(System.Web.Optimization.BundleTable.Bundles);
		}
	}
}