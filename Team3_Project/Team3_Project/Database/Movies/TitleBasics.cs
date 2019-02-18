namespace Team3_Project.Database.Movies {
	public class TitleBasics : Abstract {
		protected override System.String table() {
			return "title_basics";
		}
		protected override System.String[] column() {
			return new System.String[] { "tconst" , "titleType" , "primaryTitle" , "originalTitle" , "isAdult" , "startYear" , "endYear" , "runtimeMinutes" , "genres" };
		}
	}
}