namespace Team3_Project.Controllers {
	public class ProfileController : System.Web.Mvc.Controller {
		// GET: Profile
		public new System.Web.Mvc.ActionResult Profile(System.String id = "-1") {
			Databases.type.Int32 identifier = new Databases.type.Int32(-1);
			Databases.type.Int32 UserId = new Databases.type.Int32(0);
			identifier.parse(id);
			UserId.cast(this.Session["UserId"]);
			System.Int32 profile = identifier.value < 0 ? UserId.value : identifier.value;
			System.Int32 user = UserId.value;
			this.ViewBag.can_manage = profile == user && user != 0;
			this.ViewBag.profile = profile;
			this.ViewBag.user = user;
			this.ViewBag.list = Databases.memdixyp_film.list.list_by_user(profile);
			return this.View();
		}
	}
}