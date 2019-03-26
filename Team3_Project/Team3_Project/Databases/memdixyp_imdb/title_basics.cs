namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_basics : database {
		public type.String tconst;
		public type.String titleType;
		public type.String primaryTitle;
		public type.String originalTitle;
		public type.Boolean isAdult;
		public type.Int16 startYear;
		public type.Int16 endYear;
		public type.Int32 runtimeMinutes;
		public type.String genres;
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
		public override type.abstraction[] values() {
			return new type.abstraction[] {
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