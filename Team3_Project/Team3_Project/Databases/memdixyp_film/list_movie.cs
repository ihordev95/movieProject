namespace Team3_Project.Databases.memdixyp_film {
	public class list_movie : database {
		private static readonly System.Converter<database , list_movie> converter;
		public static readonly list_movie self;
		static list_movie() {
			converter = (database item) => (list_movie) item;
			self = new list_movie();
		}
		public static list_movie[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (list_movie) item , () => new list_movie() , subroutine , initialize);
		}
		public static list_movie individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (list_movie) item , () => new list_movie() , subroutine , initialize);
		}
		public type.Int32 list;
		public type.String movie;
		public type.DateTime added;
		private list_movie() : base(nameof(memdixyp_film) , nameof(list_movie)) {
			this.list = new type.Int32();
			this.movie = new type.String();
			this.added = new type.DateTime();
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.list),
				nameof(this.movie),
				nameof(this.added)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.list,
				this.movie,
				this.added
			};
		}
		public static void insert_individual(System.Collections.Specialized.NameValueCollection NameValueCollection) {
			list_movie list_movie = new list_movie();
			list_movie.list.form(NameValueCollection , nameof(list_movie.list));
			list_movie.movie.form(NameValueCollection , nameof(list_movie.movie));
			list_movie.added.form(NameValueCollection , nameof(list_movie.added));
			individual(insert , new System.Object[] { list_movie });
		}
		public static void delete_collection(type.Int32 list , type.String[] movie) {
			System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
			StringBuilder.Append(self.COLUMN(new System.String[] { nameof(list) }));
			StringBuilder.Append(unicode.EQUALS_SIGN);
			StringBuilder.Append(self.STRING_LITERAL(list.ToString()));
			StringBuilder.Append(unicode.SPACE);
			StringBuilder.Append(keyword.AND);
			StringBuilder.Append(unicode.SPACE);
			System.String where = StringBuilder.ToString();
			foreach (type.String item in movie) {
				StringBuilder.Clear();
				StringBuilder.Append(where);
				StringBuilder.Append(self.COLUMN(new System.String[] { nameof(movie) }));
				StringBuilder.Append(unicode.EQUALS_SIGN);
				StringBuilder.Append(self.STRING_LITERAL(item.ToString()));
				System.String query = self.DELETE(StringBuilder.ToString());
				individual(delete , new System.Object[] { query });
			}
		}
	}
}