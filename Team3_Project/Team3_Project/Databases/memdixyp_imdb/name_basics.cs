namespace Team3_Project.Databases.memdixyp_imdb {
	public class name_basics : database {
		public type.String nconst;
		public type.String primaryName;
		public type.Int16 birthYear;
		public type.Int16 deathYear;
		public type.String primaryProfession;
		public type.String knownForTitles;
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
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.nconst,
				this.primaryName,
				this.birthYear,
				this.deathYear,
				this.primaryProfession,
				this.knownForTitles
			};
		}
		public override database result(System.Data.DataRow DataRow) {
			return this;
		}
	}
}