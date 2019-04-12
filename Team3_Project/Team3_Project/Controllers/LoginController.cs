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
			System.String value = Databases.memdixyp_film.user.get_password_by_email(email.value);
            if (hash == value)
            {
                Session["UserID"] = 1;

            }
            else
            {
                ViewBag.error = "Error password was incorrect or account does not exist! Please check your information and try again.";
                ViewBag.user = email.value;
            }

            //return View("Login");
            return hash == value ? "Y" : "N";
        }
	}
}