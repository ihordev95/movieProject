namespace Team3_Project.Databases.memdixyp_film {
	public partial class user {
		public static readonly user self;
		static user() {
			self = new user();
		}
		public static user[] select_collection(System.String where = "" , System.UInt32? limit = null) {
			return self.select_collection(self.SELECT(where , limit) , (database item) => (user) item);
		}
		public static user select_individual(System.String where = "" , System.UInt32? limit = null) {
			return self.select_individual(self.SELECT(where , limit) , (database item) => (user) item);
		}
	}
}