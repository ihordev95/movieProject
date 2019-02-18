namespace Team3_Project.Database.Movies {
	public class TitleCrew : Abstract {
		private static readonly System.String[] column = { "tconst" , "directors" , "writers" };
		public TitleCrew() : base("title_crew" , column) {
		}
	}
}