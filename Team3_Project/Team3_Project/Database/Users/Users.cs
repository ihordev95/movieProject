namespace Team3_Project.Database.Movies {
	public class Users : Abstract {
		protected override System.String table() {
			return "user";
		}
		protected override System.String[] column() {
			return new System.String[] { "identifier" , "name" , "password" , "email" };
		}
	}
}