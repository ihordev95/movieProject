namespace Team3_Project.Database.Movies {
	public class TitleAkas : Abstract {
		protected override System.String table() {
			return "title_akas";
		}
		protected override System.String[] column() {
			return new System.String[] { "titleId" , "ordering" , "title" , "region" , "language" , "types" , "attributes" , "isOriginalTitle" };
		}
	}
}