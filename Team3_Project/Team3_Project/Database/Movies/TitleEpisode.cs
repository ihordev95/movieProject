namespace Team3_Project.Database.Movies {
	public class TitleEpisode : Abstract {
		private static readonly System.String[] column = { "tconst" , "parentTconst" , "seasonNumber" , "episodeNumber" };
		public TitleEpisode() : base("title_episode" , column) {
		}
	}
}