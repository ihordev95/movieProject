namespace Team3_Project.Controllers {
	public class BrowseController : System.Web.Mvc.Controller {
		public System.Web.Mvc.ActionResult BrowseMovies() {
			Databases.memdixyp_film.list[] list = Databases.memdixyp_film.list.random_lists();
			System.Int32 index = list.Length;
			Databases.memdixyp_film.view_list[][] view_list = new Databases.memdixyp_film.view_list[index][];
			while (index > 0) {
				index -= 1;
				view_list[index] = Databases.memdixyp_film.view_list.show_movie_list(list[index].identifier);
			}
			this.ViewBag.list = list;
			this.ViewBag.view_list = view_list;
			return this.View();
		}
		public System.Web.Mvc.ActionResult SearchMovies(System.String Title) {
			System.Collections.Generic.List<Helpers.Watchable> resultList = new System.Collections.Generic.List<Helpers.Watchable>();
			Helpers.ODBAPI api = new Helpers.ODBAPI();
			System.String response = api.GetAPIinfo("s=" + Title);
			api.ParseSearch(resultList , response);
			this.ViewBag.searchResults = resultList;
			return this.View();
		}
	}
}