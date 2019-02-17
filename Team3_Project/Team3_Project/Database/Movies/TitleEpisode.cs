namespace Team3_Project.Database.Movies {
	public class TitleEpisode : Abstract {
		public TitleEpisode() : this(null) {
		}
		public TitleEpisode(System.UInt32? limit) : base("title_episode" , limit) {
		}
	}
}