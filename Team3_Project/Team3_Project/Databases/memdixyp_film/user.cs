namespace Team3_Project.Databases.memdixyp_film {
	public class user : database {
		public static readonly user self;
		private static readonly System.Converter<database , user> converter;
		static user() {
			self = new user();
			converter = (database item) => (user) item;
		}
		public type.Int32 identifier;
		public type.String name;
		public type.String password;
		public type.String email;
		public user() {
			this.identifier = new type.Int32();
			this.name = new type.String();
			this.password = new type.String();
			this.email = new type.String();
		}
		public user(System.Collections.Specialized.NameValueCollection NameValueCollection) : this() {
			this.identifier.form(NameValueCollection , nameof(this.identifier));
			this.name.form(NameValueCollection , nameof(this.name));
			this.password.form(NameValueCollection , nameof(this.password));
			this.email.form(NameValueCollection , nameof(this.email));
		}
		public user(System.String name , System.String password , System.String email) {
			this.identifier = new type.Int32();
			this.name = new type.String(name);
			this.password = new type.String(password);
			this.email = new type.String(email);
		}
		protected override database constructor() {
			return new user();
		}
		protected override System.String schema() {
			return nameof(memdixyp_film);
		}
		protected override System.String table() {
			return nameof(user);
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.identifier),
				nameof(this.name),
				nameof(this.password),
				nameof(this.email)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.identifier,
				this.name,
				this.password,
				this.email
			};
		}
		public static user[] select_collection(System.String where = "" , System.UInt32? limit = null) {
			return self.select_collection(self.SELECT(where , limit) , converter);
		}
		public static user select_individual(System.String where = "" , System.UInt32? limit = null) {
			return self.select_individual(self.SELECT(where , limit) , converter);
		}
	}
}