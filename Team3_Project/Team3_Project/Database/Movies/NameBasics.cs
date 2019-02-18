namespace Team3_Project.Database.Movies {
	public class NameBasics : Abstract {
		protected override System.String table() {
			return "name_basics";
		}
		protected override System.String[] column() {
			return new System.String[] { "nconst" , "primaryName" , "birthYear" , "deathYear" , "primaryProfession" , "knownForTitles" };
		}
	}
}