namespace Team3_Project.Databases.memdixyp_film.head {
	public class collection : abstraction {
		public static list[] list(System.String query) {
			return _list.collection(query , (database item) => (list) item);
		}
		public static list_follow[] list_follow(System.String query) {
			return _list_follow.collection(query , (database item) => (list_follow) item);
		}
		public static list_movie[] list_movie(System.String query) {
			return _list_movie.collection(query , (database item) => (list_movie) item);
		}
		public static user[] user(System.String query) {
			return _user.collection(query , (database item) => (user) item);
		}
		public static view_list[] view_list(System.Int32 list) {
			view_list view_list = new view_list(list);
			System.String query = view_list.CALL();
			return _view_list.collection(query , (database item) => (view_list) item);
		}
	}
}