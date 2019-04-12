namespace Team3_Project.Controllers {
	public class ProfileController : System.Web.Mvc.Controller {
		// GET: Profile
		public new System.Web.Mvc.ActionResult Profile(System.Int32 userID = -1) {
			this.ViewBag.user = userID == -1 && this.Session["UserId"] != null && (System.Int32) this.Session["UserId"] >= 0
				? (System.Int32) this.Session["UserId"]
				: userID == -1 ? 1 : userID;
			return this.View();
		}
	}
}