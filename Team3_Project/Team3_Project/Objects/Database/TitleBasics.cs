namespace Team3_Project.Objects.Database {
	public class TitleBasics : DatabaseMovies {
		public TitleBasics() : base("title_basics") {
		}
		public TitleBasics(System.UInt32 limit) : base("title_basics", limit) {
		}
	}
}