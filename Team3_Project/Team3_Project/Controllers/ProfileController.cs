namespace Team3_Project.Controllers {
	public class ProfileController : System.Web.Mvc.Controller {
		// GET: Profile
		new public System.Web.Mvc.ActionResult Profile(System.Int32 userID=1) {
			return this.View();
		}
	}
}