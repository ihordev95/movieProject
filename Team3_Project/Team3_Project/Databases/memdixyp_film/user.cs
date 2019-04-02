namespace Team3_Project.Databases.memdixyp_film {
	public class user : database {
		public static readonly user self;
		static user() {
			self = new user();
		}
		public static user[] collection(System.String where = "" , System.UInt32? limit = null) {
			return System.Array.ConvertAll<database , user>(self.COLLECTION(self.SELECT(where , limit)) , item => (user) item);
		}
		public static user individual(System.String where = "" , System.UInt32? limit = null) {
			return (user) self.INDIVIDUAL(self.SELECT(where , limit));
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
		public override database constructor() {
			return new user();
		}
		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(user);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.identifier),
				nameof(this.name),
				nameof(this.password),
				nameof(this.email)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.identifier,
				this.name,
				this.password,
				this.email
			};
		}
	}
}