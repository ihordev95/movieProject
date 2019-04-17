namespace Team3_Project.Controllers {
	public class ListMoviesController : System.Web.Http.ApiController {
		// GET api/<controller>
		public System.Object Get() {
			return this.NotFound();
		}
		// GET api/<controller>/5
		public System.Object Get(System.Int32 id) {
			Databases.memdixyp_film.list list = Databases.memdixyp_film.list.get_list_by_id(id);
			if (list.identifier.value == 0 || list.hidden.value == true) {
				return this.NotFound(); // The list doesn't exist or is hidden, so a not found response is given
			}
			return Databases.memdixyp_film.view_list.show_movie_list(new Databases.type.Int32(id));
		}
		// POST api/<controller>
		public void Post([System.Web.Http.FromBody]System.String value) {
		}
		// PUT api/<controller>/5
		public void Put(System.Int32 id , [System.Web.Http.FromBody]System.String value) {
		}
		// DELETE api/<controller>/5
		public void Delete(System.Int32 id) {
		}
	}
}