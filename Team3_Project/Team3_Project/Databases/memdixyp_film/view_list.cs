namespace Team3_Project.Databases.memdixyp_film {
	public class view_list : database {
		public static readonly view_list self;
		private static readonly System.Converter<database , view_list> converter;
		static view_list() {
			self = new view_list();
			converter = (database item) => (view_list) item;
		}
		public type.Int32 list;
		public type.String tconst;
		public type.String primaryTitle;
		public type.Int16 startYear;
		public view_list() {
			this.list = new type.Int32();
			this.tconst = new type.String();
			this.primaryTitle = new type.String();
			this.startYear = new type.Int16();
		}
		public view_list(System.Int32 list) : this() {
			this.list = new type.Int32(list);
		}
		public override database constructor() {
			return new view_list();
		}
		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(view_list);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.list),
				nameof(this.tconst),
				nameof(this.primaryTitle),
				nameof(this.startYear)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.list,
				this.tconst,
				this.primaryTitle,
				this.startYear
			};
		}
		public override type.abstraction[] parameters() {
			return new type.abstraction[] {
				this.list
			};
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