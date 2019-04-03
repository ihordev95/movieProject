namespace Team3_Project.Databases.memdixyp_film {
	public partial class list_follow {
		public static readonly list_follow self;
		static list_follow() {
			self = new list_follow();
		}
		public static list_follow[] select_collection(System.String where = "" , System.UInt32? limit = null) {
			return self.select_collection(self.SELECT(where , limit) , (database item) => (list_follow) item);
		}
		public static list_follow select_individual(System.String where = "" , System.UInt32? limit = null) {
			return self.select_individual(self.SELECT(where , limit) , (database item) => (list_follow) item);
		}
	}
}