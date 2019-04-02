namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_ratings : database {
		public static readonly title_ratings self;
		static title_ratings() {
			self = new title_ratings();
		}
		public type.String tconst;
		public type.Single averageRating;
		public type.Int32 numVotes;
		public title_ratings() {
			this.tconst = new type.String();
			this.averageRating = new type.Single();
			this.numVotes = new type.Int32();
		}
		public override database constructor() {
			return new title_ratings();
		}
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