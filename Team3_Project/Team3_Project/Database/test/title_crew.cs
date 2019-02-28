namespace Team3_Project.Database.memdixyp_imdb {
	public class title_crew : root {
		public System.String tconst;
		public System.String directors;
		public System.String writers;
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
		public override System.Object[] values() {
			return new System.Object[] {
				this.tconst,
				this.directors,
				this.writers
			};
		}
	}
}