namespace Team3_Project.Databases.memdixyp_film {
	public class list_follow : database {
		private static readonly System.Converter<database , list_follow> converter;
		public static readonly list_follow self;
		static list_follow() {
			converter = (database item) => (list_follow) item;
			self = new list_follow();
		}
		public type.Int32 user;
		public type.Int32 list;
		private list_follow() {
			this.user = new type.Int32();
			this.list = new type.Int32();
		}
		protected override database constructor() {
			return new list_follow();
		}
		protected override System.String schema() {
			return nameof(memdixyp_film);
		}
		protected override System.String table() {
			return nameof(list_follow);
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.user),
				nameof(this.list)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.user,
				this.list
			};
		}
	}
}