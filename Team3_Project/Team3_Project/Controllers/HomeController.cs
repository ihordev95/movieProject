using System;

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
			System.String[] value = this.Request.QueryString.GetValues("table");
			Database.Database movie = new Database.Movies.TitleBasics();
			if (value != null && value.Length >= 1) {
				System.String table = value[0];
				if (table == "0") {
					movie = new Database.Movies.NameBasics();
				}
				if (table == "1") {
					movie = new Database.Movies.TitleAkas();
				}
				if (table == "2") {
					movie = new Database.Movies.TitleBasics();
				}
				if (table == "3") {
					movie = new Database.Movies.TitleCrew();
				}
				if (table == "4") {
					movie = new Database.Movies.TitleEpisode();
				}
				if (table == "5") {
					movie = new Database.Movies.TitlePrincipals();
				}
				if (table == "6") {
					movie = new Database.Movies.TitleRatings();
				}
			}
			System.Data.DataSet results = movie.SELECT(System.String.Empty, 10);
			return this.View(results);
		}
	}
}