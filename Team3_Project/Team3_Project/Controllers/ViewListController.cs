namespace Team3_Project.Controllers {
	public class ViewListController : System.Web.Mvc.Controller {
		// GET: ViewList
		public System.Web.Mvc.ActionResult ViewList(System.String id = "0") {
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
		public System.String AddList() {
			Databases.memdixyp_film.list_movie.insert_individual(this.Request.QueryString);
			Databases.memdixyp_film.posters.insert_MoviePage(this.Request.QueryString);
			return "Movie probably added!";
		}
		public System.String MakeList() {
			System.Collections.Specialized.NameValueCollection NameValueCollection = this.Request.QueryString;
			Databases.memdixyp_film.list.insert_individual(NameValueCollection);
			return "Please reload the page.";
		}
	}
}