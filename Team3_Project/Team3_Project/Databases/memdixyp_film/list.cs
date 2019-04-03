namespace Team3_Project.Databases.memdixyp_film {
	public class list : database {
		public static readonly list self;
		private static readonly System.Converter<database , list> converter;
		static list() {
			self = new list();
			converter = (database item) => (list) item;
		}
		public type.Int32 identifier;
		public type.Int32 user;
		public type.String name;
		public type.Boolean hidden; public list() {
			this.identifier = new type.Int32();
			this.user = new type.Int32();
			this.name = new type.String();
			this.hidden = new type.Boolean();
		}
		public list(System.Collections.Specialized.NameValueCollection NameValueCollection) : this() {
			this.identifier.form(NameValueCollection , nameof(this.identifier));
			this.user.form(NameValueCollection , nameof(this.user));
			this.name.form(NameValueCollection , nameof(this.name));
			this.hidden.form(NameValueCollection , nameof(this.hidden));
		}
		protected override database constructor() {
			return new list();
		}
		protected override System.String schema() {
			return nameof(memdixyp_film);
		}
		protected override System.String table() {
			return nameof(list);
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.identifier),
				nameof(this.user),
				nameof(this.name),
				nameof(this.hidden)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.identifier,
				this.user,
				this.name,
				this.hidden
			};
		}
		public static list[] select_collection(System.String where = "" , System.UInt32? limit = null) {
			return self.select_collection(self.SELECT(where , limit) , converter);
		}
		public static list select_individual(System.String where = "" , System.UInt32? limit = null) {
			return self.select_individual(self.SELECT(where , limit) , converter);
		}
		public static list get_list_by_id(System.Int32 identifier) {
			System.String where = System.String.Format("`identifier`='{0}'" , identifier);
			return self.select_individual(self.SELECT(where , null) , converter);
		}
		public static list[] list_by_user(System.Int32 user) {
			System.String where = System.String.Format("`user`='{0}'" , user);
			return self.select_collection(self.SELECT(where , null) , converter);
		}
	}
}