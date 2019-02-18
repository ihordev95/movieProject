namespace Team3_Project.Database {
	public class Abstract : Database {
		public System.Data.DataSet SELECT(System.String query) {
			return this.run(query);
		}
	}
}