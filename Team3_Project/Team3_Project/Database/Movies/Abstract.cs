namespace Team3_Project.Database.Movies {
	abstract public class Abstract : Database {
		private readonly System.String table;
		private readonly System.UInt32? limit;
		internal Abstract(System.String table) : this(table, null) {
		}
		internal Abstract(System.String table, System.UInt32? limit) : base("memdixyp_imdb") {
			this.table = table;
			this.limit = limit;
		}
		public System.Data.DataSet SELECT() {
			return this.SELECT(System.String.Empty);
		}
		public System.Data.DataSet SELECT(System.String WHERE) {
			System.String LIMIT = this.limit == null ? System.String.Empty : System.String.Concat(" LIMIT " , this.limit);
			System.String query = System.String.Concat("SELECT * FROM " , this.table , WHERE, LIMIT);
			return this.run(query);
		}
	}
}