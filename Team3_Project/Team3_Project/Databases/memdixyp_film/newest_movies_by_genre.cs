namespace Team3_Project.Databases.memdixyp_film {
	public class newest_movies_by_genre : database {
		private static readonly System.Converter<database , newest_movies_by_genre> converter;
		public static readonly newest_movies_by_genre self;
		static newest_movies_by_genre() {
			converter = (database item) => (newest_movies_by_genre) item;
			self = new newest_movies_by_genre();
		}
		public static newest_movies_by_genre[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (newest_movies_by_genre) item , () => new newest_movies_by_genre() , subroutine , initialize);
		}
		public static newest_movies_by_genre individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (newest_movies_by_genre) item , () => new newest_movies_by_genre() , subroutine , initialize);
		}
		public type.String tconst;
		public type.String primaryTitle;
		public type.Int16 startYear;
		public type.String genres;
		public type.String poster;
		private newest_movies_by_genre() : base(nameof(memdixyp_film) , nameof(newest_movies_by_genre)) {
			this.tconst = new type.String();
			this.primaryTitle = new type.String();
			this.startYear = new type.Int16();
			this.genres = new type.String();
			this.poster = new type.String();
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.primaryTitle),
				nameof(this.startYear),
				nameof(this.genres),
				nameof(this.poster)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.tconst,
				this.primaryTitle,
				this.startYear,
				this.genres,
				this.poster
			};
		}
		private static newest_movies_by_genre[] call(type.String genre , type.Int32 top) {
			System.String query = self.CALL(new type.abstraction[] {
				genre,
				top
			});
			return collection(select , new System.Object[] { query });
		}
		public static newest_movies_by_genre[] Short(System.Int32 top) {
			return call(new type.String(nameof(Short)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Romance(System.Int32 top) {
			return call(new type.String(nameof(Romance)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Drama(System.Int32 top) {
			return call(new type.String(nameof(Drama)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Comedy(System.Int32 top) {
			return call(new type.String(nameof(Comedy)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Documentary(System.Int32 top) {
			return call(new type.String(nameof(Documentary)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Crime(System.Int32 top) {
			return call(new type.String(nameof(Crime)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] War(System.Int32 top) {
			return call(new type.String(nameof(War)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Adventure(System.Int32 top) {
			return call(new type.String(nameof(Adventure)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Western(System.Int32 top) {
			return call(new type.String(nameof(Western)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Biography(System.Int32 top) {
			return call(new type.String(nameof(Biography)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Action(System.Int32 top) {
			return call(new type.String(nameof(Action)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Fantasy(System.Int32 top) {
			return call(new type.String(nameof(Fantasy)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Horror(System.Int32 top) {
			return call(new type.String(nameof(Horror)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Thriller(System.Int32 top) {
			return call(new type.String(nameof(Thriller)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Mystery(System.Int32 top) {
			return call(new type.String(nameof(Mystery)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] History(System.Int32 top) {
			return call(new type.String(nameof(History)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Music(System.Int32 top) {
			return call(new type.String(nameof(Music)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Animation(System.Int32 top) {
			return call(new type.String(nameof(Animation)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Musical(System.Int32 top) {
			return call(new type.String(nameof(Musical)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Sport(System.Int32 top) {
			return call(new type.String(nameof(Sport)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Family(System.Int32 top) {
			return call(new type.String(nameof(Family)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] News(System.Int32 top) {
			return call(new type.String(nameof(News)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Adult(System.Int32 top) {
			return call(new type.String(nameof(Adult)) , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Talk_Show(System.Int32 top) {
			return call(new type.String("Talk-Show") , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Game_Show(System.Int32 top) {
			return call(new type.String("Game-Show") , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Film_Noir(System.Int32 top) {
			return call(new type.String("Film-Noir") , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Sci_Fi(System.Int32 top) {
			return call(new type.String("Sci-Fi") , new type.Int32(top));
		}
		public static newest_movies_by_genre[] Reality_TV(System.Int32 top) {
			return call(new type.String("Reality-TV") , new type.Int32(top));
		}
	}
}