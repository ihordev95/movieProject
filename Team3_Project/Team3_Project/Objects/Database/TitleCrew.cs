namespace Team3_Project.Objects.Database {
	public class TitleCrew : DatabaseMovies {
		public TitleCrew() : this(null) {
		}
		public TitleCrew(System.UInt32? limit) : base("title_crew" , limit) {
		}
	}
}