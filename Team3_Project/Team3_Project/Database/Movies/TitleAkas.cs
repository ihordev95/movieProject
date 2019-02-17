namespace Team3_Project.Database.Movies {
	public class TitleAkas : Abstract {
		public TitleAkas() : this(null) {
		}
		public TitleAkas(System.UInt32? limit) : base("title_akas" , limit) {
		}
	}
}