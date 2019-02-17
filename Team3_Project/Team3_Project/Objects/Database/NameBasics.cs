namespace Team3_Project.Objects.Database {
	public class NameBasics : DatabaseMovies {
		public NameBasics() : this(null) {
		}
		public NameBasics(System.UInt32? limit) : base("name_basics" , limit) {
		}
	}
}