namespace Team3_Project.Database.Movies {
	public class NameBasics : Abstract {
		private static readonly System.String[] column = { "nconst" , "primaryName" , "birthYear" , "deathYear" , "primaryProfession" , "knownForTitles" };
		public NameBasics() : base("name_basics" , column) {
		}
	}
}