namespace Team3_Project.Objects.Database {
	public class DatabaseUsers : Database {
		public DatabaseUsers() : base("memdixyp_film") {
		}
		public System.Data.DataSet SELECT (System.String query) {
			return this.run(query);
		}
	}
}