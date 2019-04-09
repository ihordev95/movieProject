namespace Team3_Project.Controllers {
	public class BrowseController : System.Web.Mvc.Controller {
		public System.Web.Mvc.ActionResult BrowseMovies() {
			this.ViewBag.action = Databases.memdixyp_film.newest_movies_by_genre.Action(5);
			this.ViewBag.drama = Databases.memdixyp_film.newest_movies_by_genre.Drama(5);
			this.ViewBag.list = Databases.memdixyp_film.list.random_lists();
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