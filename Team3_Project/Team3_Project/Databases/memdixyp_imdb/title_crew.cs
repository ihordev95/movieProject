namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_crew : database {
		public type.String tconst;
		public type.String directors;
		public type.String writers;
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