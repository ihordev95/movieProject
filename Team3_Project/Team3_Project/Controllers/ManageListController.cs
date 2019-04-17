namespace Team3_Project.Controllers {
	public class ManageListController : System.Web.Mvc.Controller {
		// GET: ManageList
		public System.Web.Mvc.ActionResult ManageLists(System.String id = "0") {
			Databases.type.Int32 list_identifier = new Databases.type.Int32(0);
			Databases.type.Int32 UserId = new Databases.type.Int32(0);
			list_identifier.parse(id);
			UserId.cast(this.Session["UserId"]);
			Databases.memdixyp_film.list list = Databases.memdixyp_film.list.get_list_by_id(list_identifier.value);
			Databases.memdixyp_film.view_list[] view_list = Databases.memdixyp_film.view_list.show_movie_list(list_identifier);
			Databases.memdixyp_film.user user = Databases.memdixyp_film.user.get_user_by_id(list.user.value);
			this.ViewBag.user = user;
			this.ViewBag.list = list;
			this.ViewBag.view_list = view_list;
			this.ViewBag.can_manage = list.user.value == UserId.value && UserId.value != 0;
			return this.View();
		}
		public System.String RemoveMovie() {
			System.Collections.Specialized.NameValueCollection NameValueCollection = this.Request.QueryString;
			Databases.type.Int32 list = Databases.type.Int32.individual(Databases.type.abstraction.form , new System.Object[] { NameValueCollection , "list" });
			Databases.type.String[] movie = Databases.type.String.collection(Databases.type.abstraction.form , new System.Object[] { NameValueCollection , "movie" });
			Databases.memdixyp_film.list_movie.delete_collection(list , movie);
			System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
			foreach (Databases.type.String item in movie) {
				StringBuilder.Append(item.value);
				StringBuilder.Append(",");
			}
			return StringBuilder.ToString();
		}
	}
}