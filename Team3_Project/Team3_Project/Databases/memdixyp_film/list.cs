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
		private list() : base(nameof(memdixyp_film) , nameof(list)) {
			this.identifier = new type.Int32();
			this.user = new type.Int32();
			this.name = new type.String();
			this.hidden = new type.Boolean();
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
			System.String query = self.SELECT(where , null);
			return individual(select , new System.Object[] { query });
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
			System.String query = self.SELECT(where , null);
			return collection(select , new System.Object[] { query });
		}
		public static list[] random_lists() {
			System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
			StringBuilder.AppendFormat("`memdixyp_film`.`list`.`hidden` = '{0}'" , 0);
			StringBuilder.Append(unicode.SPACE);
			StringBuilder.Append("ORDER BY RAND()");
			System.String where = StringBuilder.ToString();
			System.String query = self.SELECT(where , 5);
			return collection(select , new System.Object[] { query });
		}
	}
}