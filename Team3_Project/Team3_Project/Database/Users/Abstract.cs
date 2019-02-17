namespace Team3_Project.Database {
	public class Abstract : Database {
		public Abstract() : base("memdixyp_film") {
		}
		public System.Data.DataSet SELECT (System.String query) {
			return this.run(query);
		}
	}
}