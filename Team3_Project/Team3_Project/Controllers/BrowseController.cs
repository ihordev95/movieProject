namespace Team3_Project.Controllers {
	public class BrowseController : System.Web.Mvc.Controller {
		public System.Web.Mvc.ActionResult BrowseMovies() {
			this.ViewBag.action = Databases.memdixyp_imdb.title_basics.lastest_movie_by_genre("Action");
			this.ViewBag.drama = Databases.memdixyp_imdb.title_basics.lastest_movie_by_genre("Drama");
			this.ViewBag.list = Databases.memdixyp_film.list.list_by_user(1);
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