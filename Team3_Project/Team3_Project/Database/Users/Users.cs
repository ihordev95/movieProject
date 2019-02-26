namespace Team3_Project.Database.Users {
	public class Users : Database {
		static Users() {
			Database.Table[typeof(Users)] = new Table("memdixyp_imdb" , "user" , new System.String[] {
				"identifier",
				"name",
				"password",
				"email"
			});
		}
		public override System.Data.DataSet SELECT(System.String where = "" , System.UInt32? limit = null) {
			return this.run(Database.Table[typeof(Users)].SELECT(where , limit));
		}
		public override System.Data.DataSet INSERT() {
			throw new System.NotImplementedException();
		}
		public override System.String[] values() {
			throw new System.NotImplementedException();
		}
	}
}