namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_episode : database {
		public static readonly title_episode self;
		private static readonly System.Converter<database , title_episode> converter;
		static title_episode() {
			self = new title_episode();
			converter = (database item) => (title_episode) item;
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
		protected override database constructor() {
			return new title_episode();
		}
		protected override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		protected override System.String table() {
			return nameof(title_episode);
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.parentTconst),
				nameof(this.seasonNumber),
				nameof(this.episodeNumber)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.tconst,
				this.parentTconst,
				this.seasonNumber,
				this.episodeNumber
			};
		}
	}
}