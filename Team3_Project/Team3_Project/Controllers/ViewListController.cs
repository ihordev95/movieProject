namespace Team3_Project.Controllers {
	public class ViewListController : System.Web.Mvc.Controller {
		// GET: ViewList
		public System.Web.Mvc.ActionResult ViewList() {
			System.Collections.Specialized.NameValueCollection QueryString = this.Request.QueryString;
			System.Int32 list = Databases.url.Int32(this.Request.QueryString , "list");
			list = list == 0 ? 1 : list;
			Databases.memdixyp_film.view_list view_list = new Databases.memdixyp_film.view_list(list);
			System.Data.DataSet result = view_list.CALL();
			return this.View(result);
		}
	}
}