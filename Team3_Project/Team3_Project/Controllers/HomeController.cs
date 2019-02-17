namespace Team3_Project.Controllers {
	public class HomeController : System.Web.Mvc.Controller {
		public System.Web.Mvc.ActionResult Index() {
			return this.View();
		}

		public System.Web.Mvc.ActionResult About() {
			DatabaseAccess db = new DatabaseAccess();
			this.ViewBag.Message = "Your application description page.";
			System.Data.DataSet results = db.GetDataSet();
			return this.View(results);
		}

		public System.Web.Mvc.ActionResult Contact() {
			this.ViewBag.Message = "Your contact page.";
			Objects.Database.DatabaseMovies movie = new Objects.Database.DatabaseMovies();
			System.Data.DataSet results = movie.SELECT("SELECT * FROM title_basics limit 10;");
			return this.View(results);
		}
	}
}