namespace Team3_Project.Controllers {
	public class LoginController : System.Web.Mvc.Controller {
		// GET: Login
		public System.Web.Mvc.ActionResult Login() {
			return this.View();
		}
		public System.String CheckPassword() {
			Databases.type.String email = new Databases.type.String();
			Databases.type.String password = new Databases.type.String();
			email.form(this.Request.QueryString , "email");
			password.form(this.Request.QueryString , "password");
			System.String hash = new DatabaseAccess().getHash(password.value).ToString();
			Databases.memdixyp_film.user user = Databases.memdixyp_film.user.get_user_by_email(email.value);
			if (hash == user.password.value) {
				this.Session["UserID"] = user.identifier.value;
			}
			else {
				this.ViewBag.error = "Error password was incorrect or account does not exist! Please check your information and try again.";
				this.ViewBag.user = email.value;
			}
			return hash == user.password.value ? "Y" : "N";
		}

        public System.Web.Mvc.ActionResult Logout()
        {
            this.Session["UserId"] = null;
            return this.View();
        }
    }
}