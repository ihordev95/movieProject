namespace Team3_Project.Database.Movies {
	public class NameBasics : Abstract {
		public NameBasics() : this(null) {
		}
		public NameBasics(System.UInt32? limit) : base("name_basics" , limit) {
		}
	}
}