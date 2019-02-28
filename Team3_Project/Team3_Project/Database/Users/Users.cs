namespace Team3_Project.Database.Users {
	public class Users : root {
		static Users() {
			root.Table[typeof(Users)] = new Tables("memdixyp_film" , "user" , new System.String[] {
				"identifier",
				"name",
				"password",
				"email"
			});
		}
		public System.Int32 identifier;
		public System.String name;
		public System.String password;
		public System.String email;
		public Users() {
			this.identifier = 0;
			this.name = "";
			this.password = "";
			this.email = "";
		}
		public override System.Data.DataSet SELECT(System.String where = "" , System.UInt32? limit = null) {
			return this.run(root.Table[typeof(Users)].SELECT(where , limit));
		}
		public override System.Data.DataSet INSERT() {
			return this.run(root.Table[typeof(Users)].INSERT(this));
		}
		public override System.String[] values() {
			return new System.String[] {
				"'" + this.identifier.ToString() + "'",
				"'" + this.name.ToString() + "'",
				"'" + this.password.ToString() + "'",
				"'" + this.email.ToString() + "'",
			};
			throw new System.NotImplementedException();
		}
	}
}