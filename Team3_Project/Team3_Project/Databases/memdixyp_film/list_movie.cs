namespace Team3_Project.Databases.memdixyp_film {
	public class list_movie : database {
		public static readonly list_movie self;
		private static readonly System.Converter<database , list_movie> converter;
		static list_movie() {
			self = new list_movie();
			converter = (database item) => (list_movie) item;
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
		public override database constructor() {
			return new list_movie();
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
		public static list_movie[] select_collection(System.String where = "" , System.UInt32? limit = null) {
			return self.select_collection(self.SELECT(where , limit) , converter);
		}
		public static list_movie select_individual(System.String where = "" , System.UInt32? limit = null) {
			return self.select_individual(self.SELECT(where , limit) , converter);
		}
	}
}