namespace Team3_Project.Objects.Database {
	public class TitleAkas : DatabaseMovies {
		public TitleAkas() : this(null) {
		}
		public TitleAkas(System.UInt32? limit) : base("title_akas" , limit) {
		}
	}
}