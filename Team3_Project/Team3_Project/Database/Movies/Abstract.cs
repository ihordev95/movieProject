namespace Team3_Project.Database.Movies {
	public abstract class Abstract : Database {
		public System.String log;
		private readonly System.String table;
		private readonly System.String column;
		protected Abstract(System.String table , System.String[] column) : base("memdixyp_imdb") {
			this.log = System.String.Empty;
			this.table = table;
			this.column = System.String.Join(", " , column);
		}
		public System.Data.DataSet SELECT(System.String WHERE = "" , System.UInt32? limit = null) {
			System.String SELECT = System.String.Concat("SELECT " , this.column , " FROM " , this.table);
			System.String LIMIT = limit == null ? System.String.Empty : System.String.Concat(" LIMIT " , limit , ";");
			System.String query = System.String.Concat(SELECT , WHERE , LIMIT);
			this.log = query;
			return this.run(query);
		}
	}
}