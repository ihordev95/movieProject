namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_crew : database {
		public static readonly title_crew self;
		static title_crew() {
			self = new title_crew();
		}
		public type.String tconst;
		public type.String directors;
		public type.String writers;
		public title_crew() {
			this.tconst = new type.String();
			this.directors = new type.String();
			this.writers = new type.String();
		}
		public override database constructor() {
			return new title_crew();
		}
		public override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		public override System.String table() {
			return nameof(title_crew);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.directors),
				nameof(this.writers)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.tconst,
				this.directors,
				this.writers
			};
		}
	}
}