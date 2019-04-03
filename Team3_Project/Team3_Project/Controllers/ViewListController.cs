namespace Team3_Project.Controllers {
	public class ViewListController : System.Web.Mvc.Controller {
		// GET: ViewList
		public System.Web.Mvc.ActionResult ViewList(System.String id = "1") {
			Databases.type.Int32 identifier = new Databases.type.Int32(1);
			identifier.parse(id);
			System.String SELECT = Databases.memdixyp_film.list.head.body.SELECT(System.String.Format("`identifier`='{0}'" , identifier));
			this.ViewBag.list = Databases.memdixyp_film.list.head.select_individual(SELECT);
			this.ViewBag.view_list = Databases.memdixyp_film.view_list.head.call_collection(identifier.value);
			return this.View();
		}
		public System.String AddList() {
			Databases.memdixyp_film.list_movie.body list_movie = new Databases.memdixyp_film.list_movie.body(this.Request.QueryString);
			Databases.database.insert_individual(list_movie);
			return "alert message";
		}
	}
}