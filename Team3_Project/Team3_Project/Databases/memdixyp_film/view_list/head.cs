namespace Team3_Project.Databases.memdixyp_film {
	public partial class view_list {
		public static readonly view_list self;
		static view_list() {
			self = new view_list();
		}
		public static view_list[] call_collection(System.Int32 value) {
			view_list view_List = new view_list(value);
			return self.select_collection(view_List.CALL() , (database item) => (view_list) item);
		}
		public static view_list call_individual(System.Int32 value) {
			view_list view_List = new view_list(value);
			return self.select_individual(view_List.CALL() , (database item) => (view_list) item);
		}
	}
}