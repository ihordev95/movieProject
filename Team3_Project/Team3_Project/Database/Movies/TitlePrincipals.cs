namespace Team3_Project.Database.Movies {
	public class TitlePrincipals : Abstract {
		private static readonly System.String[] column = { "tconst" , "ordering" , "nconst" , "category" , "job" , "characters" };
		public TitlePrincipals() : base("title_principals" , column) {
		}
	}
}