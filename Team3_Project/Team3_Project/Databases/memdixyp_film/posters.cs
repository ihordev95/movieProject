namespace Team3_Project.Databases.memdixyp_film {
	public class posters : database {
		private static readonly System.Converter<database , posters> converter;
		public static readonly posters self;
		static posters() {
			converter = (database item) => (posters) item;
			self = new posters();
		}
		public static posters[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (posters) item , () => new posters() , subroutine , initialize);
		}
		public static posters individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (posters) item , () => new posters() , subroutine , initialize);
		}
		public type.String tconst;
		public type.String poster;
		private posters() : base(nameof(memdixyp_film) , "poster") {
			this.tconst = new type.String();
			this.poster = new type.String();
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.poster)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.tconst,
				this.poster
			};
		}
		public static void insert_MoviePage(System.Collections.Specialized.NameValueCollection NameValueCollection) {
			posters posters = new posters();
			posters.tconst.form(NameValueCollection , "movie");
			posters.poster.form(NameValueCollection , "poster");
			individual(insert , new System.Object[] { posters });
		}
	}
}