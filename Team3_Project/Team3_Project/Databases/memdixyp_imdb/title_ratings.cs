namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_ratings : database {
		private static readonly System.Converter<database , title_ratings> converter;
		public static readonly title_ratings self;
		static title_ratings() {
			converter = (database item) => (title_ratings) item;
			self = new title_ratings();
		}
		public static title_ratings[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (title_ratings) item , () => new title_ratings() , subroutine , initialize);
		}
		public static title_ratings individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (title_ratings) item , () => new title_ratings() , subroutine , initialize);
		}
		public type.String tconst;
		public type.Single averageRating;
		public type.Int32 numVotes;
		private title_ratings() {
			this.tconst = new type.String();
			this.averageRating = new type.Single();
			this.numVotes = new type.Int32();
		}
		protected override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		protected override System.String table() {
			return nameof(title_ratings);
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.averageRating),
				nameof(this.numVotes)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.tconst,
				this.averageRating,
				this.numVotes
			};
		}
	}
}