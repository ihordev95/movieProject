namespace Team3_Project.Controllers {
	public class ViewListController : System.Web.Mvc.Controller {
		// GET: ViewList
		public System.Web.Mvc.ActionResult ViewList(System.String id = "1") {
			Databases.type.Int32 identifier = new Databases.type.Int32(1);
			identifier.parse(id);
			this.ViewBag.list = Databases.memdixyp_film.list.select_individual(identifier.value , null);
			this.ViewBag.view_list = Databases.memdixyp_film.view_list.call_collection(identifier.value);
			return this.View();
		}
		public System.String AddList() {
			Databases.memdixyp_film.list_movie list_movie = new Databases.memdixyp_film.list_movie(this.Request.QueryString);
			Databases.database.insert_individual(list_movie);
			return "Movie probably added!";
		}
	}
}