namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_crew : database {
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