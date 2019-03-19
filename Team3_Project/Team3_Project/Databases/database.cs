namespace Team3_Project.Databases {
	public abstract class database {
		public abstract System.String schema();
		public abstract System.String table();
		public abstract System.String[] columns();
		public abstract System.Object[] values();
		public System.String log = System.String.Empty;
		public System.String error = System.String.Empty;
		private System.String QUOTE_IDENTIFIER(System.String IDENTIFIER) {
			return System.String.Concat(unicode.GRAVE_ACCENT , IDENTIFIER , unicode.GRAVE_ACCENT);
		}
		private System.String STRING_LITERAL(System.String STRING) {
			return System.String.Concat(unicode.APOSTROPHE , STRING , unicode.APOSTROPHE);
		}
		private System.String QUALIFY_IDENTIFIER(System.String QUALIFIER , System.String IDENTIFIER) {
			return System.String.Concat(QUALIFIER , unicode.FULL_STOP , IDENTIFIER);
		}
		public System.String SCHEMA() {
			System.String schema = this.schema();
			return this.QUOTE_IDENTIFIER(schema);
		}
		public System.String TABLE() {
			System.String schema = this.SCHEMA();
			System.String table = this.table();
			return this.QUALIFY_IDENTIFIER(schema , this.QUOTE_IDENTIFIER(table));
		}
		public System.String COLUMN() {
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
		public System.String VALUES() {
			System.Object[] values = this.values();
			System.Int32 index = 0;
			System.Int32 count = values.Length;
			if (count > 0) {
				System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
				do {
					System.Object value = values[index] ?? "\0";
					StringBuilder.Append(this.STRING_LITERAL(value.ToString()));
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
		public System.Data.DataSet SELECT(System.String where = "" , System.UInt32? limit = null) {
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
			return this.run(query.ToString());
		}
		public System.Data.DataSet INSERT() {
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
			return this.run(query.ToString());
		}
		private static readonly System.String connection_string;
		static database() {
			MySql.Data.MySqlClient.MySqlConnectionStringBuilder MySqlConnectionStringBuilder = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder {
				Server = "memdixyp.mysql.db.hostpoint.ch" ,
				UserID = "memdixyp_user" ,
				Password = "rmpvzSp4BsNm" ,
				SslMode = MySql.Data.MySqlClient.MySqlSslMode.None
			};
			connection_string = MySqlConnectionStringBuilder.ToString();
		}
		private System.Data.DataSet run(System.String query) {
			this.log = query;
			System.Data.DataSet DataSet = new System.Data.DataSet();
			using (MySql.Data.MySqlClient.MySqlConnection MySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connection_string)) {
				using (MySql.Data.MySqlClient.MySqlCommand MySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query , MySqlConnection)) {
					using (MySql.Data.MySqlClient.MySqlDataAdapter MySqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(MySqlCommand)) {
						try {
							MySqlDataAdapter.Fill(DataSet);
						}
						catch (MySql.Data.MySqlClient.MySqlException MySqlException) {
							this.error = MySqlException.Message;
						}
					}
				}
			}
			return DataSet;
		}
		public static database get(System.Collections.Specialized.NameValueCollection NameValueCollection) {
			switch (url.String(NameValueCollection , "table")) {
				case "name_basics":
					return new memdixyp_imdb.name_basics();
				case "title_akas":
					return new memdixyp_imdb.title_akas();
				case "title_basics":
					return new memdixyp_imdb.title_basics();
				case "title_crew":
					return new memdixyp_imdb.title_crew();
				case "title_episode":
					return new memdixyp_imdb.title_episode();
				case "title_principals":
					return new memdixyp_imdb.title_principals();
				case "title_ratings":
					return new memdixyp_imdb.title_ratings();
				case "list":
					return new memdixyp_film.list(NameValueCollection);
				case "list_follow":
					return new memdixyp_film.list_follow(NameValueCollection);
				case "list_movie":
					return new memdixyp_film.list_movie(NameValueCollection);
				case "user":
					return new memdixyp_film.user(NameValueCollection);
				default:
					return new memdixyp_imdb.title_basics();
			}
		}
	}
}