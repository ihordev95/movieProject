namespace Team3_Project.Database.Movies {
	public class TitlePrincipals : Abstract {
		protected override System.String table() {
			return "title_principals";
		}
		protected override System.String[] column() {
			return new System.String[] { "tconst" , "ordering" , "nconst" , "category" , "job" , "characters" };
		}
	}
}