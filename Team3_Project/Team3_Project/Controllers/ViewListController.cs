namespace Team3_Project.Controllers {
	public class ViewListController : System.Web.Mvc.Controller {
		// GET: ViewList
		public System.Web.Mvc.ActionResult ViewList(System.String id = "1") {
			Databases.type.Int32 identifier = new Databases.type.Int32(1);
			identifier.parse(id);
			//
			System.Collections.Specialized.NameValueCollection QueryString = this.Request.QueryString;
			Databases.memdixyp_film.list list = new Databases.memdixyp_film.list(QueryString);
			System.Data.DataSet result = list.SELECT(System.String.Format("identifier='{0}'" , identifier));
			System.Data.DataRow DataRow = result.Tables[0].Rows[0];
			if (DataRow != null && this.ViewBag.list != null) {
				this.ViewBag.list.identifier = DataRow[0] ?? "0";
				this.ViewBag.list.user = DataRow[1] ?? "0";
				this.ViewBag.list.name = DataRow[2] ?? "none";
				this.ViewBag.list.hidden = DataRow[3] ?? "0";
			}
			//
			Databases.memdixyp_film.view_list view_list = new Databases.memdixyp_film.view_list(identifier.value);
			result = view_list.CALL();
			this.ViewBag.list = view_list;
			return this.View(result);
		}
	}
}