namespace Team3_Project.Objects.Database {
	public class TitleEpisode : DatabaseMovies {
		public TitleEpisode() : this(null) {
		}
		public TitleEpisode(System.UInt32? limit) : base("title_episode" , limit) {
		}
	}
}