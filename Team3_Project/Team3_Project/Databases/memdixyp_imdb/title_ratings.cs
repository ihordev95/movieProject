namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_ratings : database {
		public type.String tconst;
		public type.Single averageRating;
		public type.Int32 numVotes;
		public override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		public override System.String table() {
			return nameof(title_ratings);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.averageRating),
				nameof(this.numVotes)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.tconst,
				this.averageRating,
				this.numVotes
			};
		}
	}
}