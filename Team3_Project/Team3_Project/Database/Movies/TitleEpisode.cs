namespace Team3_Project.Database.Movies {
	public class TitleEpisode : Database {
		static TitleEpisode() {
			Database.Table[typeof(TitleEpisode)] = new Tables("memdixyp_imdb" , "title_episode" , new System.String[] {
				"tconst",
				"parentTconst",
				"seasonNumber",
				"episodeNumber"
			});
		}
		public override System.Data.DataSet SELECT(System.String where = "" , System.UInt32? limit = null) {
			return this.run(Database.Table[typeof(TitleEpisode)].SELECT(where , limit));
		}
		public override System.Data.DataSet INSERT() {
			throw new System.NotImplementedException();
		}
		public override System.String[] values() {
			throw new System.NotImplementedException();
		}
	}
}