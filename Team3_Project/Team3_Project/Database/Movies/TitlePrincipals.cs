namespace Team3_Project.Database.Movies {
	public class TitlePrincipals : Abstract {
		public TitlePrincipals() : this(null) {
		}
		public TitlePrincipals(System.UInt32? limit) : base("title_principals" , limit) {
		}
	}
}