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
			database.database movie = new database.memdixyp_imdb.title_basics();
			if (value != null && value.Length >= 1) {
				System.String table = value[0];
				if (table == "0") {
					movie = new database.memdixyp_imdb.name_basics();
				}
				if (table == "1") {
					movie = new database.memdixyp_imdb.title_akas();
				}
				if (table == "2") {
					movie = new database.memdixyp_imdb.title_basics();
				}
				if (table == "3") {
					movie = new database.memdixyp_imdb.title_crew();
				}
				if (table == "4") {
					movie = new database.memdixyp_imdb.title_episode();
				}
				if (table == "5") {
					movie = new database.memdixyp_imdb.title_principals();
				}
				if (table == "6") {
					movie = new database.memdixyp_imdb.title_ratings();
				}
				if (table == "7") {
					movie = new database.memdixyp_film.user();
				}
			}
			System.String query = movie.SELECT(System.String.Empty , 50);
			System.Data.DataSet results = movie.run(query);
			database.memdixyp_film.user user = new database.memdixyp_film.user();
			System.String[] email = this.Request.QueryString.GetValues("email");
			if (email != null && email.Length >= 1) {
				user.email = email[0];
			}
			System.String[] password = this.Request.QueryString.GetValues("password");
			if (password != null && password.Length >= 1) {
				user.password = password[0];
			}
			System.String[] name = this.Request.QueryString.GetValues("name");
			if (name != null && name.Length >= 1) {
				user.name = name[0];
			}
			user.INSERT();
			return this.View(results);
		}
	}
}