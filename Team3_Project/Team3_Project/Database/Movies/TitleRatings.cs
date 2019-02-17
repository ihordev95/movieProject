namespace Team3_Project.Database.Movies {
	public class TitleRatings : Abstract {
		public TitleRatings() : this(null) {
		}
		public TitleRatings(System.UInt32? limit) : base("title_ratings" , limit) {
		}
	}
}