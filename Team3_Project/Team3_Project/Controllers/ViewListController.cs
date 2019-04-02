namespace Team3_Project.Controllers {
	public class ViewListController : System.Web.Mvc.Controller {
		// GET: ViewList
		public System.Web.Mvc.ActionResult ViewList(System.String id = "1") {
			Databases.type.Int32 identifier = new Databases.type.Int32(1);
			identifier.parse(id);

			System.String SELECT = Databases.memdixyp_film.list.self.SELECT(System.String.Format("identifier='{0}'" , identifier));
			Databases.memdixyp_film.list list = (Databases.memdixyp_film.list) Databases.memdixyp_film.list.self.individual(SELECT);
			this.ViewBag.list = list;

			System.String CALL = Databases.memdixyp_film.view_list.self.CALL();
			Databases.memdixyp_film.view_list[] view_list = (Databases.memdixyp_film.view_list[]) Databases.memdixyp_film.view_list.self.collection(CALL);
			this.ViewBag.view_list = view_list;
			/*

						this.ViewBag.list = Databases.memdixyp_film.list.select(System.String.Format("identifier='{0}'" , identifier));
						Databases.memdixyp_film.view_list view_list = new Databases.memdixyp_film.view_list(identifier.value);
						System.Data.DataSet result = view_list.CALL();
						return this.View(result);
						*/
			return this.View();
		}
		public System.String AddList() {
			Databases.memdixyp_film.list_movie list_movie = new Databases.memdixyp_film.list_movie(this.Request.QueryString);
			list_movie.INSERT();
			return "alert message";
		}
	}
}