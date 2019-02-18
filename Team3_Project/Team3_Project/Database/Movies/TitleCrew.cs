namespace Team3_Project.Database.Movies {
	public class TitleCrew : Abstract {
		protected override System.String table() {
			return "title_crew";
		}
		protected override System.String[] column() {
			return new System.String[] { "tconst" , "directors" , "writers" };
		}
	}
}