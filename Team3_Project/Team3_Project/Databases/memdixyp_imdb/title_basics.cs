namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_basics : database {
		private static readonly System.Converter<database , title_basics> converter;
		public static readonly title_basics self;
		static title_basics() {
			converter = (database item) => (title_basics) item;
			self = new title_basics();
		}
		public static title_basics[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (title_basics) item , () => new title_basics() , subroutine , initialize);
		}
		public static title_basics individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (title_basics) item , () => new title_basics() , subroutine , initialize);
		}
		public type.String tconst;
		public type.String titleType;
		public type.String primaryTitle;
		public type.String originalTitle;
		public type.Boolean isAdult;
		public type.Int16 startYear;
		public type.Int16 endYear;
		public type.Int32 runtimeMinutes;
		public type.String genres;
		private title_basics() : base(nameof(memdixyp_imdb) , nameof(title_basics)) {
			this.tconst = new type.String();
			this.titleType = new type.String();
			this.primaryTitle = new type.String();
			this.originalTitle = new type.String();
			this.isAdult = new type.Boolean();
			this.startYear = new type.Int16();
			this.endYear = new type.Int16();
			this.runtimeMinutes = new type.Int32();
			this.genres = new type.String();
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.titleType),
				nameof(this.primaryTitle),
				nameof(this.originalTitle),
				nameof(this.isAdult),
				nameof(this.startYear),
				nameof(this.endYear),
				nameof(this.runtimeMinutes),
				nameof(this.genres)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.tconst,
				this.titleType,
				this.primaryTitle,
				this.originalTitle,
				this.isAdult,
				this.startYear,
				this.endYear,
				this.runtimeMinutes,
				this.genres
			};
		}
	}
}