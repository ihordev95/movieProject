namespace Team3_Project.Controllers {
	public class ViewListController : System.Web.Mvc.Controller {
		// GET: ViewList
		public System.Web.Mvc.ActionResult ViewList(System.String id = "1") {
			Databases.type.Int32 identifier = new Databases.type.Int32(1);
			identifier.parse(id);
			this.ViewBag.list = Databases.memdixyp_film.list.get_list_by_id(identifier.value);
			this.ViewBag.view_list = Databases.memdixyp_film.view_list.show_movie_list(identifier);
			return this.View();
		}
		public System.String AddList() {
			Databases.memdixyp_film.list_movie.insert_individual(this.Request.QueryString);
			Databases.memdixyp_film.posters.insert_MoviePage(this.Request.QueryString);
			return "Movie probably added!";
		}
		public System.String MakeList() {
			System.Collections.Specialized.NameValueCollection NameValueCollection = this.Request.QueryString;
			Databases.memdixyp_film.list.insert_individual(NameValueCollection);
			/*
			Databases.type.Int32 UserId = new Databases.type.Int32();
			UserId.cast(this.Session["UserId"]);
			Databases.memdixyp_film.list[] list = Databases.memdixyp_film.list.list_by_user(UserId.value);
			System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
			foreach (Databases.type.String item in movie) {
				StringBuilder.Append(item.value);
				StringBuilder.Append(",");
			}
			return StringBuilder.ToString();
			*/
			return "Please reload the page.";
		}
	}
}