using System.Collections.Generic;
using Newtonsoft.Json;

namespace Team3_Project.Controllers {
	public class BrowseController : System.Web.Mvc.Controller {
		// GET: Browse
		public System.Web.Mvc.ActionResult BrowseMovies() {
			return this.View();
		}

        public System.Web.Mvc.ActionResult SearchMovies(System.String Title)
        {
            List<Helpers.Watchable> resultList = new List<Helpers.Watchable>();

            Helpers.ODBAPI api = new Helpers.ODBAPI();
            System.String response = api.GetAPIinfo("s=" + Title);
            api.ParseSearch(resultList, response);
            this.ViewBag.searchResults = resultList;
            
            return this.View();
        }
	}
}