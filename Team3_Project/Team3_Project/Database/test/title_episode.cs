namespace Team3_Project.Database.memdixyp_imdb {
	public class title_episode : root {
		public System.String tconst;
		public System.String parentTconst;
		public System.Int16? seasonNumber;
		public System.Int32? episodeNumber;
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
		public override System.Object[] values() {
			return new System.Object[] {
				this.tconst,
				this.parentTconst,
				this.seasonNumber,
				this.episodeNumber
			};
		}
	}
}