namespace Team3_Project.Databases.memdixyp_film {
	public class list : database {
		private static readonly System.Converter<database , list> converter;
		public static readonly list self;
		static list() {
			converter = (database item) => (list) item;
			self = new list();
		}
		public static list[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (list) item , () => new list() , subroutine , initialize);
		}
		public static list individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (list) item , () => new list() , subroutine , initialize);
		}
		public type.Int32 identifier;
		public type.Int32 user;
		public type.String name;
		public type.Boolean hidden;
		private list() {
			this.identifier = new type.Int32();
			this.user = new type.Int32();
			this.name = new type.String();
			this.hidden = new type.Boolean();
		}
		protected override database data_fill() {
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
		public static list get_list_by_id(System.Int32 identifier) {
			System.String[] columns = new System.String[] {
				nameof(identifier)
			};
			System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
			StringBuilder.Append(self.COLUMN(columns));
			StringBuilder.Append(unicode.EQUALS_SIGN);
			StringBuilder.Append(self.STRING_LITERAL(identifier.ToString()));
			System.String where = StringBuilder.ToString();
			return self.select_individual(self.SELECT(where , null) , converter);
		}
		public static list[] list_by_user(System.Int32 user) {
			System.String[] columns = new System.String[] {
				nameof(user)
			};
			System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
			StringBuilder.Append(self.COLUMN(columns));
			StringBuilder.Append(unicode.EQUALS_SIGN);
			StringBuilder.Append(self.STRING_LITERAL(user.ToString()));
			System.String where = StringBuilder.ToString();
			return self.select_collection(self.SELECT(where , null) , converter);
		}
	}
}