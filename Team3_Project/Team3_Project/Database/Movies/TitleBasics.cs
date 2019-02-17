namespace Team3_Project.Database.Movies {
	public class TitleBasics : Abstract {
		public TitleBasics() : this(null) {
		}
		public TitleBasics(System.UInt32? limit) : base("title_basics", limit) {
		}
	}
}