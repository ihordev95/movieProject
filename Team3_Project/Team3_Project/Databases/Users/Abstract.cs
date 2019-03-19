namespace Team3_Project.Database {
	public class Abstract : Database {
		protected override System.String database() {
			return "memdixyp_film";
		}
		protected override System.String table() {
			throw new System.NotImplementedException();
		}
		protected override System.String[] column() {
			throw new System.NotImplementedException();
		}
	}
}