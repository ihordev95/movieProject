namespace Team3_Project.Database.memdixyp_imdb {
	public class title_principals : root {
		public System.String tconst;
		public System.Int16 ordering;
		public System.String nconst;
		public System.String category;
		public System.String job;
		public System.String characters;
		public override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		public override System.String table() {
			return nameof(title_principals);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.ordering),
				nameof(this.nconst),
				nameof(this.category),
				nameof(this.job),
				nameof(this.characters)
			};
		}
		public override System.Object[] values() {
			return new System.Object[] {
				this.tconst,
				this.ordering,
				this.nconst,
				this.category,
				this.job,
				this.characters
			};
		}
	}
}