using Newtonsoft.Json;

namespace Team3_Project.Controllers {
	public class MovieController : System.Web.Mvc.Controller {
		// GET: Movie
		public System.Web.Mvc.ActionResult MoviePage(System.String ID = "tt0000001") {
			Databases.memdixyp_imdb.title_akas title_akas = new Databases.memdixyp_imdb.title_akas();
			Databases.memdixyp_imdb.title_basics title_basics = new Databases.memdixyp_imdb.title_basics();
			Databases.memdixyp_imdb.title_episode title_episode = new Databases.memdixyp_imdb.title_episode();
			Databases.memdixyp_imdb.title_ratings title_ratings = new Databases.memdixyp_imdb.title_ratings();
			System.Data.DataSet results = new System.Data.DataSet();
			System.String movie = Databases.url.String(this.Request.QueryString , "movie");
			results.Merge(title_akas.SELECT(System.String.Format("titleId='{0}'" , movie)));
			results.Merge(title_basics.SELECT(System.String.Format("tconst='{0}'" , movie)));
			results.Merge(title_episode.SELECT(System.String.Format("tconst='{0}'" , movie)));
			results.Merge(title_ratings.SELECT(System.String.Format("tconst='{0}'" , movie)));


            Helpers.ODBAPI api = new Helpers.ODBAPI();
            System.String response = api.GetAPIinfo("i=" + ID);
            Helpers.Watchable w = JsonConvert.DeserializeObject<Helpers.Watchable>(response);
            this.ViewBag.json = w;
            return this.View(results);
		}
	}
}