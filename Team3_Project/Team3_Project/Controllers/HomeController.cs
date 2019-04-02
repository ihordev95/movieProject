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
			{
				Databases.type.Boolean insert_list = new Databases.type.Boolean();
				insert_list.form(QueryString , nameof(insert_list));
				if (insert_list.value) {
					new Databases.memdixyp_film.list(QueryString).INSERT();
				}
			}
			{
				Databases.type.Boolean insert_list_follow = new Databases.type.Boolean();
				insert_list_follow.form(QueryString , nameof(insert_list_follow));
				if (insert_list_follow.value) {
					new Databases.memdixyp_film.list_follow(QueryString).INSERT();
				}
			}
			{
				Databases.type.Boolean insert_list_movie = new Databases.type.Boolean();
				insert_list_movie.form(QueryString , nameof(insert_list_movie));
				if (insert_list_movie.value) {
					new Databases.memdixyp_film.list_movie(QueryString).INSERT();
				}
			}
			{
				Databases.type.Boolean insert_user = new Databases.type.Boolean();
				insert_user.form(QueryString , nameof(insert_user));
				if (insert_user.value) {
					new Databases.memdixyp_film.user(QueryString).INSERT();
				}
			}
			Databases.database movie = Databases.database.get(QueryString);
			Databases.type.String where = new Databases.type.String();
			where.form(QueryString , "where");
			System.Data.DataSet results = movie.SELECT(where.value , 50);
			return this.View(results);
		}
	}
}