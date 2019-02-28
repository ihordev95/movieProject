namespace Team3_Project.Database.memdixyp_imdb {
	public class name_basics : root {
		public System.String nconst;
		public System.String primaryName;
		public System.Int16? birthYear;
		public System.Int16? deathYear;
		public System.String primaryProfession;
		public System.String knownForTitles;
		public override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		public override System.String table() {
			return nameof(name_basics);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.nconst),
				nameof(this.primaryName),
				nameof(this.birthYear),
				nameof(this.deathYear),
				nameof(this.primaryProfession),
				nameof(this.knownForTitles)
			};
		}
		public override System.Object[] values() {
			return new System.Object[] {
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