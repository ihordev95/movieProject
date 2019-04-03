namespace Team3_Project.Databases.memdixyp_imdb {
	public class name_basics : database {
		public static readonly name_basics self;
		private static readonly System.Converter<database , name_basics> converter;
		static name_basics() {
			self = new name_basics();
			converter = (database item) => (name_basics) item;
		}
		public type.String nconst;
		public type.String primaryName;
		public type.Int16 birthYear;
		public type.Int16 deathYear;
		public type.String primaryProfession;
		public type.String knownForTitles;
		public name_basics() {
			this.nconst = new type.String();
			this.primaryName = new type.String();
			this.birthYear = new type.Int16();
			this.deathYear = new type.Int16();
			this.primaryProfession = new type.String();
			this.knownForTitles = new type.String();
		}
		protected override database constructor() {
			return new name_basics();
		}
		protected override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		protected override System.String table() {
			return nameof(name_basics);
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.nconst),
				nameof(this.primaryName),
				nameof(this.birthYear),
				nameof(this.deathYear),
				nameof(this.primaryProfession),
				nameof(this.knownForTitles)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.nconst,
				this.primaryName,
				this.birthYear,
				this.deathYear,
				this.primaryProfession,
				this.knownForTitles
			};
		}
	}
}