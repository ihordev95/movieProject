namespace Team3_Project.Databases.memdixyp_film {
	public partial class list {
		public static readonly list self;
		static list() {
			self = new list();
		}
		private static System.String where(System.Int32? identifier , System.Int32? user) {
			System.String where = System.String.Empty;
			if (identifier != null) {
				where = System.String.Format("`identifier`='{0}'" , identifier);
			}
			if (user != null) {
				where = System.String.Format("`user`='{0}'" , user);
			}
			return where;
		}
		public static list[] select_collection(System.Int32? identifier , System.Int32? user) {
			return self.select_collection(self.SELECT(where(identifier , user) , null) , (database item) => (list) item);
		}
		public static list select_individual(System.Int32? identifier , System.Int32? user) {
			return self.select_individual(self.SELECT(where(identifier , user) , null) , (database item) => (list) item);
		}
	}
}