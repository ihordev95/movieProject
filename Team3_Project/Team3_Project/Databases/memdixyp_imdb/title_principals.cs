namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_principals : database {
		public type.String tconst;
		public type.Int16 ordering;
		public type.String nconst;
		public type.String category;
		public type.String job;
		public type.String characters;
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
		public override type.abstraction[] values() {
			return new type.abstraction[] {
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