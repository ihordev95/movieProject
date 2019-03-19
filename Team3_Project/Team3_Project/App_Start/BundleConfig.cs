namespace Team3_Project {
	public class BundleConfig {
		// For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
		public static void RegisterBundles(System.Web.Optimization.BundleCollection bundles) {
			bundles.Add(new System.Web.Optimization.ScriptBundle("~/bundles/jquery").Include(
						"~/Scripts/jquery-{version}.js"));

			bundles.Add(new System.Web.Optimization.ScriptBundle("~/bundles/jqueryval").Include(
						"~/Scripts/jquery.validate*"));

			// Use the development version of Modernizr to develop with and learn from. Then, when you're
			// ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
			bundles.Add(new System.Web.Optimization.ScriptBundle("~/bundles/modernizr").Include(
						"~/Scripts/modernizr-*"));

			bundles.Add(new System.Web.Optimization.ScriptBundle("~/bundles/bootstrap").Include(
					  "~/Scripts/bootstrap.js" ,
					  "~/Scripts/respond.js"));

			bundles.Add(new System.Web.Optimization.StyleBundle("~/Styles/css").Include(
					  "~/Styles/bootstrap.css" ,
					  "~/Styles/site.css"));
		}
	}
}
