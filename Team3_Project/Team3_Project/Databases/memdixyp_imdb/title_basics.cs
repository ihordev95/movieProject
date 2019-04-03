namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_basics : database {
		public static readonly title_basics self;
		private static readonly System.Converter<database , title_basics> converter;
		static title_basics() {
			self = new title_basics();
			converter = (database item) => (title_basics) item;
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
		public title_basics() {
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
		protected override database constructor() {
			return new title_basics();
		}
		protected override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		protected override System.String table() {
			return nameof(title_basics);
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