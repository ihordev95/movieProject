namespace Team3_Project.Databases.memdixyp_film {
	public class list_follow : database {
		public static readonly list_follow self;
		private static readonly System.Converter<database , list_follow> converter;
		static list_follow() {
			self = new list_follow();
			converter = (database item) => (list_follow) item;
		}
		public type.Int32 user;
		public type.Int32 list;
		public list_follow() {
			this.user = new type.Int32();
			this.list = new type.Int32();
		}
		public list_follow(System.Collections.Specialized.NameValueCollection NameValueCollection) : this() {
			this.user.form(NameValueCollection , nameof(this.user));
			this.list.form(NameValueCollection , nameof(this.list));
		}
		public override database constructor() {
			return new list_follow();
		}
		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(list_follow);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.user),
				nameof(this.list)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.user,
				this.list
			};
		}
		public static list_follow[] select_collection(System.String where = "" , System.UInt32? limit = null) {
			return self.select_collection(self.SELECT(where , limit) , converter);
		}
		public static list_follow select_individual(System.String where = "" , System.UInt32? limit = null) {
			return self.select_individual(self.SELECT(where , limit) , converter);
		}
	}
}