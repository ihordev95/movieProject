namespace Team3_Project.Controllers {
	public class ProfileController : System.Web.Mvc.Controller {
		// GET: Profile
		new public System.Web.Mvc.ActionResult Profile(System.Int32 userID=-1) {
            if (userID == -1 && Session["UserId"] != null && (int)Session["UserId"] >= 0)
                ViewBag.user = (int)Session["UserId"];
            else if (userID == -1)
                ViewBag.user = 1;
            else
                ViewBag.user = userID;
			return this.View();
		}
	}
}