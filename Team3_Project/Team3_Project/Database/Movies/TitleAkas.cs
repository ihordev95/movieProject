namespace Team3_Project.Database.Movies {
	public class TitleAkas : Abstract {
		private static readonly System.String[] column = { "titleId" , "ordering" , "title" , "region" , "language" , "types" , "attributes" , "isOriginalTitle" };
		public TitleAkas() : base("title_akas" , column) {
		}
	}
}