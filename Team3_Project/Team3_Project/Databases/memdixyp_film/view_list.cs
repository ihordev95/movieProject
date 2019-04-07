namespace Team3_Project.Databases.memdixyp_film {
	public class view_list : database {
		private static readonly System.Converter<database , view_list> converter;
		public static readonly view_list self;
		static view_list() {
			converter = (database item) => (view_list) item;
			self = new view_list();
		}
		public type.Int32 list;
		public type.String tconst;
		public type.String primaryTitle;
		public type.Int16 startYear;
		private view_list() {
			this.list = new type.Int32();
			this.tconst = new type.String();
			this.primaryTitle = new type.String();
			this.startYear = new type.Int16();
		}
		protected override database data_fill() {
			return new view_list();
		}
		protected override System.String schema() {
			return nameof(memdixyp_film);
		}
		protected override System.String table() {
			return nameof(view_list);
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.list),
				nameof(this.tconst),
				nameof(this.primaryTitle),
				nameof(this.startYear)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.list,
				this.tconst,
				this.primaryTitle,
				this.startYear
			};
		}
		public static view_list[] show_movie_list(type.Int32 list) {
			System.String query = self.CALL(new type.abstraction[] {
				list
			});
			return self.select_collection(query , converter);
		}
	}
}