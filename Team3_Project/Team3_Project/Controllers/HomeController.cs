namespace Team3_Project.Controllers {
	public class HomeController : System.Web.Mvc.Controller {
		public System.Web.Mvc.ActionResult Index() {
			return this.View();
		}

		public System.Web.Mvc.ActionResult About() {
			DatabaseAccess db = new DatabaseAccess();
			this.ViewBag.Message = "Your application description page." + db.getHash("TestHash2").ToString();
			System.Data.DataSet results = db.GetDataSet();
            //db.insertAccount("TEST", "TESTEMAIL@EMAIL.COM", "Password");
            //Nullable<bool> test = db.comparePass("TESTEMAIL@EMAIL2.COM", "Password");
			return this.View(results);
		}

		public System.Web.Mvc.ActionResult Contact() {
			this.ViewBag.Message = "Your contact page.";
			System.Collections.Specialized.NameValueCollection QueryString = this.Request.QueryString;
			database.database movie = database.database.get(QueryString);
			System.String where = database.url.String(QueryString , "where");
			System.Data.DataSet results = movie.SELECT(where , 50);
			database.memdixyp_film.user user = new database.memdixyp_film.user(QueryString);
			user.INSERT();
			return this.View(results);
		}
	}
}