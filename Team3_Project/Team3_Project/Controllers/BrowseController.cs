using System.Collections.Generic;
using Newtonsoft.Json;

namespace Team3_Project.Controllers {
	public class BrowseController : System.Web.Mvc.Controller {
		// GET: Browse
		public System.Web.Mvc.ActionResult BrowseMovies() {
			return this.View();
		}

        public System.Web.Mvc.ActionResult SearchMovies(string Title)
        {
            List<Helpers.Watchable> resultList = new List<Helpers.Watchable>();

            Helpers.ODBAPI api = new Helpers.ODBAPI();
            string response = api.GetAPIinfo("s=" + Title);
            api.ParseSearch(resultList, response);
            ViewBag.searchResults = resultList;
            
            return this.View();
        }
	}
}