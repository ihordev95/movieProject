namespace Team3_Project.Database.Movies {
	public class TitleEpisode : Abstract {
		protected override System.String table() {
			return "title_episode";
		}
		protected override System.String[] column() {
			return new System.String[] { "tconst" , "parentTconst" , "seasonNumber" , "episodeNumber" };
		}
	}
}