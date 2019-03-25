namespace Team3_Project.Controllers {
	public class ViewListController : System.Web.Mvc.Controller {
		// GET: ViewList
		public System.Web.Mvc.ActionResult ViewList(System.String id = "1") {
			System.Int32 list = Databases.parse.Int32(id , 1);
			Databases.memdixyp_film.view_list view_list = new Databases.memdixyp_film.view_list(list);
			System.Data.DataSet result = view_list.CALL();
			return this.View(result);
		}
	}
}