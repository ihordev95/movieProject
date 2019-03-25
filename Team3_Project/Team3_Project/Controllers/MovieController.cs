using Newtonsoft.Json;

namespace Team3_Project.Controllers {
	public class MovieController : System.Web.Mvc.Controller {
		// GET: Movie
		public System.Web.Mvc.ActionResult MoviePage(System.String ID = "tt0000001") {
			Helpers.ODBAPI api = new Helpers.ODBAPI();
			System.String response = api.GetAPIinfo("i=" + ID);
			Helpers.Watchable w = JsonConvert.DeserializeObject<Helpers.Watchable>(response);
			this.ViewBag.json = w;
			return this.View();
		}
	}
}