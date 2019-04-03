namespace Team3_Project.Databases.memdixyp_film {
	public partial class list {
		public static readonly list self;
		static list() {
			self = new list();
		}
		public static list[] select_collection(System.String where = "" , System.UInt32? limit = null) {
			return self.select_collection(self.SELECT(where , limit) , (database item) => (list) item);
		}
		public static list select_individual(System.String where = "" , System.UInt32? limit = null) {
			return self.select_individual(self.SELECT(where , limit) , (database item) => (list) item);
		}
	}
}