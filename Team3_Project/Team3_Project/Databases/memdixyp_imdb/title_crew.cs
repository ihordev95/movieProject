namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_crew : database {
		public static readonly title_crew self;
		private static readonly System.Converter<database , title_crew> converter;
		static title_crew() {
			self = new title_crew();
			converter = (database item) => (title_crew) item;
		}
		public type.String tconst;
		public type.String directors;
		public type.String writers;
		public title_crew() {
			this.tconst = new type.String();
			this.directors = new type.String();
			this.writers = new type.String();
		}
		protected override database constructor() {
			return new title_crew();
		}
		protected override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		protected override System.String table() {
			return nameof(title_crew);
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.directors),
				nameof(this.writers)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.tconst,
				this.directors,
				this.writers
			};
		}
	}
}