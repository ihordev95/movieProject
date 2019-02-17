namespace Team3_Project.Objects.Database {
	public class TitlePrincipals : DatabaseMovies {
		public TitlePrincipals() : this(null) {
		}
		public TitlePrincipals(System.UInt32? limit) : base("title_principals" , limit) {
		}
	}
}