namespace Team3_Project.Controllers {
	public class ManageListController : System.Web.Mvc.Controller {
		// GET: ManageList
		public System.Web.Mvc.ActionResult ManageLists(System.String id = "1") {
			Databases.type.Int32 identifier = new Databases.type.Int32(1);
			identifier.parse(id);
			this.ViewBag.identifier = identifier.value;
			this.ViewBag.list = Databases.memdixyp_film.list.get_list_by_id(identifier.value);
			this.ViewBag.view_list = Databases.memdixyp_film.view_list.show_movie_list(identifier);
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