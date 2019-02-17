namespace Team3_Project.Database.Movies {
	public class TitleCrew : Abstract {
		public TitleCrew() : this(null) {
		}
		public TitleCrew(System.UInt32? limit) : base("title_crew" , limit) {
		}
	}
}