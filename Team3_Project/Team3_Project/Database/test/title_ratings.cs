namespace Team3_Project.Database.memdixyp_imdb {
	public class title_ratings : root {
		public System.String tconst;
		public System.Single averageRating;
		public System.Int32 numVotes;
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
		public override System.Object[] values() {
			return new System.Object[] {
				this.tconst,
				this.averageRating,
				this.numVotes
			};
		}
	}
}