namespace Team3_Project.Database.Movies {
	public class TitleRatings : Abstract {
		private static readonly System.String[] column = { "tconst" , "averageRating" , "numVotes" };
		public TitleRatings() : base("title_ratings" , column) {
		}
	}
}