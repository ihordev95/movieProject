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
		public view_list(System.Int32 list) : this() {
			this.list = new type.Int32(list);
		}
		protected override database constructor() {
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
		protected override type.abstraction[] parameters() {
			return new type.abstraction[] {
				this.list
			};
		}
		public static view_list[] call_collection(System.Int32 value) {
			view_list view_List = new view_list(value);
			return self.select_collection(view_List.CALL() , (database item) => (view_list) item);
		}
	}
}