namespace Team3_Project.Databases.memdixyp_film {
	public class user : database {
		private static readonly System.Converter<database , user> converter;
		public static readonly user self;
		static user() {
			converter = (database item) => (user) item;
			self = new user();
		}
		public static user[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (user) item , () => new user() , subroutine , initialize);
		}
		public static user individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (user) item , () => new user() , subroutine , initialize);
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
			user user = new user {
				name = new type.String(name) ,
				password = new type.String(password) ,
				email = new type.String(email)
			};
			insert(user);
		}
	}
}