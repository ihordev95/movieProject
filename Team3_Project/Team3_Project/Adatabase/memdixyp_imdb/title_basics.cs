namespace Team3_Project.database.memdixyp_imdb {
	public class title_basics : database {
		public System.String tconst;
		public System.String titleType;
		public System.String primaryTitle;
		public System.String originalTitle;
		public System.Boolean isAdult;
		public System.Int16? startYear;
		public System.Int16? endYear;
		public System.Int32? runtimeMinutes;
		public System.String genres;
		public override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		public override System.String table() {
			return nameof(title_basics);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.titleType),
				nameof(this.primaryTitle),
				nameof(this.originalTitle),
				nameof(this.isAdult),
				nameof(this.startYear),
				nameof(this.endYear),
				nameof(this.runtimeMinutes),
				nameof(this.genres)
			};
		}
		public override System.Object[] values() {
			return new System.Object[] {
				this.tconst,
				this.titleType,
				this.primaryTitle,
				this.originalTitle,
				this.isAdult,
				this.startYear,
				this.endYear,
				this.runtimeMinutes,
				this.genres
			};
		}
	}
}