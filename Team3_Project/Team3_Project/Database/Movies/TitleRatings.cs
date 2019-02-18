namespace Team3_Project.Database.Movies {
	public class TitleRatings : Abstract {
		protected override System.String table() {
			return "title_ratings";
		}
		protected override System.String[] column() {
			return new System.String[] { "tconst" , "averageRating" , "numVotes" };
		}
	}
}