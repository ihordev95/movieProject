namespace Team3_Project.Databases {
	public abstract class database {
		private static System.String log = System.String.Empty;
		private static System.String error = System.String.Empty;
		private static readonly System.String connection_string;
		static database() {
			MySql.Data.MySqlClient.MySqlConnectionStringBuilder MySqlConnectionStringBuilder = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder {
				Password = "rmpvzSp4BsNm" ,
				Server = "memdixyp.mysql.db.hostpoint.ch" ,
				SslMode = MySql.Data.MySqlClient.MySqlSslMode.None ,
				UserID = "memdixyp_user"
			};
			connection_string = MySqlConnectionStringBuilder.ToString();
		}
		private System.String COLUMN() {
			System.String table = this.TABLE();
			System.String[] columns = this.columns();
			System.Int32 index = 0;
			System.Int32 count = columns.Length;
			if (count > 0) {
				System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
				do {
					StringBuilder.Append(this.QUALIFY_IDENTIFIER(table , this.QUOTE_IDENTIFIER(columns[index])));
					index += 1;
					if (index >= count) {
						break;
					}
					StringBuilder.Append(keyword.COMMA_SEPARATED);
				}
				while (true);
				return StringBuilder.ToString();
			}
			return System.String.Empty;
		}
		private System.String LIMIT(System.UInt32? limit = null) {
			if (limit != null) {
				System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
				StringBuilder.Append(unicode.SPACE);
				StringBuilder.Append(keyword.LIMIT);
				StringBuilder.Append(unicode.SPACE);
				StringBuilder.Append(limit);
				return StringBuilder.ToString();
			}
			return System.String.Empty;
		}
		private System.String PARAMETERS() {
			return this.value_array(this.parameters());
		}
		private System.String QUALIFY_IDENTIFIER(System.String QUALIFIER , System.String IDENTIFIER) {
			return System.String.Concat(QUALIFIER , unicode.FULL_STOP , IDENTIFIER);
		}
		private System.String QUOTE_IDENTIFIER(System.String IDENTIFIER) {
			return System.String.Concat(unicode.GRAVE_ACCENT , IDENTIFIER , unicode.GRAVE_ACCENT);
		}
		private System.String SCHEMA() {
			System.String schema = this.schema();
			return this.QUOTE_IDENTIFIER(schema);
		}
		private System.String STRING_LITERAL(System.String STRING) {
			return System.String.Concat(unicode.APOSTROPHE , STRING , unicode.APOSTROPHE);
		}
		private System.String TABLE() {
			System.String schema = this.SCHEMA();
			System.String table = this.table();
			return this.QUALIFY_IDENTIFIER(schema , this.QUOTE_IDENTIFIER(table));
		}
		private System.String VALUES() {
			return this.value_array(this.values());
		}
		private System.String WHERE(System.String where = "") {
			if (!System.String.IsNullOrEmpty(where)) {
				System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
				StringBuilder.Append(unicode.SPACE);
				StringBuilder.Append(keyword.WHERE);
				StringBuilder.Append(unicode.SPACE);
				StringBuilder.Append(where);
				return StringBuilder.ToString();
			}
			return System.String.Empty;
		}
		private database constructor(System.Data.DataRow DataRow) {
			database item = this.constructor();
			type.abstraction[] values = item.values();
			System.Int32 index = values.Length;
			while (index > 0) {
				index -= 1;
				System.Object Object = DataRow[index];
				values[index].cast(Object);
			}
			return item;
		}
		private static System.Data.DataTable run(System.String query) {
			log = query;
			System.Data.DataSet DataSet = new System.Data.DataSet();
			using (MySql.Data.MySqlClient.MySqlConnection MySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connection_string)) {
				using (MySql.Data.MySqlClient.MySqlCommand MySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query ?? System.String.Empty , MySqlConnection)) {
					using (MySql.Data.MySqlClient.MySqlDataAdapter MySqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(MySqlCommand)) {
						try {
							MySqlDataAdapter.Fill(DataSet);
						}
						catch (MySql.Data.MySqlClient.MySqlException MySqlException) {
							error = MySqlException.Message;
						}
					}
				}
			}
			return DataSet.Tables.Count > 0 ? DataSet.Tables[0] : new System.Data.DataTable();
		}
		private System.Collections.Generic.List<database> select(System.String query) {
			System.Collections.Generic.List<database> list = new System.Collections.Generic.List<database>();
			System.Data.DataTable DataTable = run(query);
			foreach (System.Data.DataRow DataRow in DataTable.Rows) {
				database item = this.constructor(DataRow);
				list.Add(item);
			}
			return list;
		}
		private System.String value_array(type.abstraction[] array) {
			System.Int32 index = 0;
			System.Int32 count = array.Length;
			if (count > 0) {
				System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
				do {
					StringBuilder.Append(this.STRING_LITERAL(array[index].ToString()));
					index += 1;
					if (index >= count) {
						break;
					}
					StringBuilder.Append(keyword.COMMA_SEPARATED);
				}
				while (true);
				return StringBuilder.ToString();
			}
			return System.String.Empty;
		}
		protected abstract database constructor();
		protected abstract System.String schema();
		protected abstract System.String table();
		protected abstract System.String[] columns();
		protected abstract type.abstraction[] values();
		protected virtual type.abstraction[] parameters() {
			return new type.abstraction[] {
			};
		}
		protected System.String CALL() {
			System.Text.StringBuilder query = new System.Text.StringBuilder(255);
			query.Append(keyword.CALL);
			query.Append(unicode.SPACE);
			query.Append(this.TABLE());
			query.Append(unicode.SPACE);
			query.Append(unicode.LEFT_PARENTHESIS);
			query.Append(this.PARAMETERS());
			query.Append(unicode.RIGHT_PARENTHESIS);
			query.Append(unicode.SEMICOLON);
			return query.ToString();
		}
		protected System.String INSERT() {
			System.Text.StringBuilder query = new System.Text.StringBuilder(255);
			query.Append(keyword.INSERT);
			query.Append(unicode.SPACE);
			query.Append(keyword.INTO);
			query.Append(unicode.SPACE);
			query.Append(this.TABLE());
			query.Append(unicode.SPACE);
			query.Append(unicode.LEFT_PARENTHESIS);
			query.Append(this.COLUMN());
			query.Append(unicode.RIGHT_PARENTHESIS);
			query.Append(unicode.SPACE);
			query.Append(keyword.VALUES);
			query.Append(unicode.SPACE);
			query.Append(unicode.LEFT_PARENTHESIS);
			query.Append(this.VALUES());
			query.Append(unicode.RIGHT_PARENTHESIS);
			query.Append(unicode.SEMICOLON);
			return query.ToString();
		}
		protected System.String SELECT(System.String where = "" , System.UInt32? limit = null) {
			System.Text.StringBuilder query = new System.Text.StringBuilder(255);
			query.Append(keyword.SELECT);
			query.Append(unicode.SPACE);
			query.Append(this.COLUMN());
			query.Append(unicode.SPACE);
			query.Append(keyword.FROM);
			query.Append(unicode.SPACE);
			query.Append(this.TABLE());
			query.Append(this.WHERE(where));
			query.Append(this.LIMIT(limit));
			query.Append(unicode.SEMICOLON);
			return query.ToString();
		}
		protected static void insert(database individual) {
			System.String query = individual.INSERT();
			run(query);
		}
		protected static void insert(database[] collection) {
			foreach (database individual in collection) {
				insert(individual);
			}
		}
		protected type[] select_collection<type>(System.String query , System.Converter<database , type> converter) {
			System.Collections.Generic.List<database> list = this.select(query);
			database[] array = list.ToArray();
			return System.Array.ConvertAll(array , converter);
		}
		protected type select_individual<type>(System.String query , System.Converter<database , type> converter) {
			System.Collections.Generic.List<database> list = this.select(query);
			database[] array = list.Count > 0 ? list.ToArray() : new database[] { this.constructor() };
			return System.Array.ConvertAll(array , converter)[0];
		}
	}
}