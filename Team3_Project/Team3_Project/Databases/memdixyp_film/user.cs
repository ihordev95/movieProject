namespace Team3_Project.Databases.memdixyp_film {
	public class user : database {
		private static readonly System.Converter<database , user> converter;
		public static readonly user self;
		static user() {
			converter = (database item) => (user) item;
			self = new user();
		}
		public type.Int32 identifier;
		public type.String name;
		public type.String password;
		public type.String email;
		private user() {
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
		public static void insert_individual(System.String name , System.String password , System.String email) {
			user user = new user(name , password , email);
			database.insert(user);
		}
	}
}