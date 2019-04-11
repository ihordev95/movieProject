namespace Team3_Project.Controllers {
	public class RegisterController : System.Web.Mvc.Controller {
		// GET: Register
		public System.Web.Mvc.ActionResult Register() {
			return this.View();
		}
		public System.String AddUser() {
			Databases.type.String email = new Databases.type.String();
			Databases.type.String displayname = new Databases.type.String();
			Databases.type.String password = new Databases.type.String();
			Databases.type.String confirmpassword = new Databases.type.String();
			email.form(this.Request.QueryString , "email");
			displayname.form(this.Request.QueryString , "displayname");
			password.form(this.Request.QueryString , "password");
			confirmpassword.form(this.Request.QueryString , "confirmpassword");
			System.String result = "N";
			if (password.value == confirmpassword.value) {
				Databases.memdixyp_film.user.insert_individual(displayname.value , new DatabaseAccess().getHash(password.value).ToString() , email.value);
				result = "Y";
			}
			return result;
		}
	}
}