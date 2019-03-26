namespace Team3_Project.Controllers {
	public class HomeController : System.Web.Mvc.Controller {
		public System.Web.Mvc.ActionResult Index() {
			return this.View();
		}

		public System.Web.Mvc.ActionResult About() {
			DatabaseAccess db = new DatabaseAccess();
			this.ViewBag.Message = "Your application description page." + db.getHash("TestHash2").ToString();
			System.Data.DataSet results = db.GetDataSet();
			return this.View(results);
		}

		public System.Web.Mvc.ActionResult Contact() {
			this.ViewBag.Message = "Your contact page.";
			System.Collections.Specialized.NameValueCollection QueryString = this.Request.QueryString;
			//
			if (Databases.url.Boolean(QueryString , "insert_list")) {
				new Databases.memdixyp_film.list(QueryString).INSERT();
			}
			if (Databases.url.Boolean(QueryString , "insert_list_follow")) {
				new Databases.memdixyp_film.list_follow(QueryString).INSERT();
			}
			if (Databases.url.Boolean(QueryString , "insert_list_movie")) {
				new Databases.memdixyp_film.list_movie(QueryString).INSERT();
			}
			if (Databases.url.Boolean(QueryString , "insert_user")) {
				new Databases.memdixyp_film.user(QueryString).INSERT();
			}
			//
			Databases.database movie = Databases.database.get(QueryString);
			System.String where = Databases.url.String(QueryString , "where");
			System.Data.DataSet results = movie.SELECT(where , 50);
			return this.View(results);
		}
	}
}