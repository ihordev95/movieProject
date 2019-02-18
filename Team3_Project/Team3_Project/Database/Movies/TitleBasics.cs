namespace Team3_Project.Database.Movies {
	public class TitleBasics : Abstract {
		private static readonly System.String[] column = { "tconst" , "titleType" , "primaryTitle" , "originalTitle" , "isAdult" , "startYear" , "endYear" , "runtimeMinutes" , "genres" };
		public TitleBasics() : base("title_basics" , column) {
		}
	}
}