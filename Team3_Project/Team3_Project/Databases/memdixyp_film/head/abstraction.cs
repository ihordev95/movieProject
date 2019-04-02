namespace Team3_Project.Databases.memdixyp_film.head {
	public abstract class abstraction {
		protected static readonly list _list;
		protected static readonly list_follow _list_follow;
		protected static readonly list_movie _list_movie;
		protected static readonly user _user;
		protected static readonly view_list _view_list;
		static abstraction() {
			_list = new list();
			_list_follow = new list_follow();
			_list_movie = new list_movie();
			_user = new user();
			_view_list = new view_list();
		}
	}
}