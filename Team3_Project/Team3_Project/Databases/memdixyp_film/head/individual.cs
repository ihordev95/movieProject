namespace Team3_Project.Databases.memdixyp_film.head {
	public class individual : abstraction {
		public static list list(System.String query) {
			return _list.individual(query , (database item) => (list) item);
		}
		public static list_follow list_follow(System.String query) {
			return _list_follow.individual(query , (database item) => (list_follow) item);
		}
		public static list_movie list_movie(System.String query) {
			return _list_movie.individual(query , (database item) => (list_movie) item);
		}
		public static user user(System.String query) {
			return _user.individual(query , (database item) => (user) item);
		}
		public static view_list view_list(System.Int32 list) {
			view_list view_list = new view_list(list);
			System.String query = view_list.CALL();
			return _view_list.individual(query , (database item) => (view_list) item);
		}
	}
}