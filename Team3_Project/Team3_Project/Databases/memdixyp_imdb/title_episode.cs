namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_episode : database {
		public static readonly title_episode self;
		static title_episode() {
			self = new title_episode();
		}
		public type.String tconst;
		public type.String parentTconst;
		public type.Int16 seasonNumber;
		public type.Int32 episodeNumber;
		public title_episode() {
			this.tconst = new type.String();
			this.parentTconst = new type.String();
			this.seasonNumber = new type.Int16();
			this.episodeNumber = new type.Int32();
		}
		public override database constructor() {
			return new title_episode();
		}
		public override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		public override System.String table() {
			return nameof(title_episode);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.parentTconst),
				nameof(this.seasonNumber),
				nameof(this.episodeNumber)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.tconst,
				this.parentTconst,
				this.seasonNumber,
				this.episodeNumber
			};
		}
		public override database result(System.Data.DataRow DataRow) {
			return this;
		}
	}
}