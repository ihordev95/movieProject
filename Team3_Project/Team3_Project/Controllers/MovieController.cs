namespace Team3_Project.Controllers {
	public class MovieController : System.Web.Mvc.Controller {
		// GET: Movie
		public System.Web.Mvc.ActionResult MoviePage(System.String ID = "tt0000001") {
			Helpers.ODBAPI api = new Helpers.ODBAPI();
			System.String response = api.GetAPIinfo("i=" + ID);
			Helpers.Watchable watchable = Newtonsoft.Json.JsonConvert.DeserializeObject<Helpers.Watchable>(response);
			this.ViewBag.json = watchable;
			System.Int32 identifier = 1; // PLACEHOLDER
			this.ViewBag.list = Databases.memdixyp_film.list.collection(System.String.Format("`user`='{0}'" , identifier));
			return this.View();
		}
	}
}