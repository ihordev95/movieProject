namespace Team3_Project.Controllers {
	public class ManageListController : System.Web.Mvc.Controller {
		// GET: ManageList
		public System.Web.Mvc.ActionResult ManageLists(System.String id = "1") {
			Databases.type.Int32 identifier = new Databases.type.Int32(1);
			identifier.parse(id);
			this.ViewBag.view_list = Databases.memdixyp_film.view_list.show_movie_list(identifier);
			return this.View();
		}
	}
}