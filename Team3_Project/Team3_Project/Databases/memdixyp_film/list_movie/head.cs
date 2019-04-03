namespace Team3_Project.Databases.memdixyp_film {
	public partial class list_movie {
		public static readonly list_movie self;
		static list_movie() {
			self = new list_movie();
		}
		public static list_movie[] select_collection(System.String where = "" , System.UInt32? limit = null) {
			return self.select_collection(self.SELECT(where , limit) , (database item) => (list_movie) item);
		}
		public static list_movie select_individual(System.String where = "" , System.UInt32? limit = null) {
			return self.select_individual(self.SELECT(where , limit) , (database item) => (list_movie) item);
		}
	}
}