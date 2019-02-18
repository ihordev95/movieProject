namespace Team3_Project.Database.Movies {
	public abstract class Abstract : Database {
		public System.String log;
		protected abstract System.String table();
		protected abstract System.String[] column();
		protected Abstract() {
			this.log = System.String.Empty;
		}
		public System.Data.DataSet SELECT(System.String WHERE = "" , System.UInt32? limit = null) {
			System.String COLUMN = System.String.Join(", " , this.column());
			System.String TABLE = System.String.Concat("memdixyp_imdb." , this.table());
			System.String SELECT = System.String.Concat("SELECT " , COLUMN , " FROM " , TABLE);
			System.String LIMIT = limit == null ? System.String.Empty : System.String.Concat(" LIMIT " , limit , ";");
			System.String query = System.String.Concat(SELECT , WHERE , LIMIT);
			this.log = query;
			return this.run(query);
		}
	}
}