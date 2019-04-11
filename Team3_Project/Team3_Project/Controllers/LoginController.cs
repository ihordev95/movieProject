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
			// TODO
			// I think this is how we hash passwords. Until we hashing passwords on login, keep it unhashed for testing.
			// System.String hash = new DatabaseAccess().getHash(password.value).ToString();
			System.String hash = password.value;
			System.String value = Databases.memdixyp_film.user.get_password_by_email(email.value);
			return password.value == value ? "Y" : "N";
		}
	}
}