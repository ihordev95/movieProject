namespace Team3_Project.Objects.Database {
	public class TitleRatings : DatabaseMovies {
		public TitleRatings() : this(null) {
		}
		public TitleRatings(System.UInt32? limit) : base("title_ratings" , limit) {
		}
	}
}