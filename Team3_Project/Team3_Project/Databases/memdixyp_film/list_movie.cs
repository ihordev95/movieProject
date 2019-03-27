namespace Team3_Project.Databases.memdixyp_film {
	public class list_movie : database {
		public static list_movie select(System.String where = "" , System.UInt32? limit = null) {
			list_movie list_movie = new list_movie();
			System.Data.DataSet data = list_movie.SELECT(where , limit);
			System.Data.DataRow DataRow = data.Tables[0].Rows[0];
			return (list_movie) list_movie.result(DataRow);
		}
		public type.Int32 list;
		public type.String movie;
		public type.DateTime added;
		public list_movie() {
			this.list = new type.Int32();
			this.movie = new type.String();
			this.added = new type.DateTime();
		}
		public list_movie(System.Collections.Specialized.NameValueCollection NameValueCollection) : this() {
			this.list.form(NameValueCollection , nameof(this.list));
			this.movie.form(NameValueCollection , nameof(this.movie));
			this.added.form(NameValueCollection , nameof(this.added));
		}
		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(list_movie);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.list),
				nameof(this.movie),
				nameof(this.added)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.list,
				this.movie,
				this.added
			};
		}
		public override database result(System.Data.DataRow DataRow) {
			this.list.load(DataRow , 0);
			this.movie.load(DataRow , 1);
			this.added.load(DataRow , 2);
			return this;
		}
	}
}