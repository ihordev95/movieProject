namespace Team3_Project.Controllers {
	public class MovieController : System.Web.Mvc.Controller {
		// GET: Movie
		public System.Web.Mvc.ActionResult MoviePage(System.String id = "tt0000001") {
			Helpers.ODBAPI api = new Helpers.ODBAPI();
			System.String response = api.GetAPIinfo("i=" + id);
			Helpers.Watchable watchable = Newtonsoft.Json.JsonConvert.DeserializeObject<Helpers.Watchable>(response);
			this.ViewBag.json = watchable;
			this.ViewBag.list = Databases.memdixyp_film.list.list_by_user(System.Convert.ToInt32(this.Session["UserId"]));
			return this.View();
		}
	}
}