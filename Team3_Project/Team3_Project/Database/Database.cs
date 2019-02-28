namespace Team3_Project.database {
	public abstract class database {
		public abstract System.String schema();
		public abstract System.String table();
		public abstract System.String[] columns();
		public abstract System.Object[] values();
		private System.String QUOTE_IDENTIFIER(System.String IDENTIFIER) {
			return System.String.Concat(keyword.GRAVE_ACCENT , IDENTIFIER , keyword.GRAVE_ACCENT);
		}

		private System.String STRING_LITERAL(System.String STRING) {
			return System.String.Concat(keyword.APOSTROPHE , STRING , keyword.APOSTROPHE);
		}

		private System.String QUALIFY_IDENTIFIER(System.String QUALIFIER , System.String IDENTIFIER) {
			return System.String.Concat(QUALIFIER , keyword.FULL_STOP , IDENTIFIER);
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

		private System.String LIMIT(System.UInt32? limit = null) {
			if (limit != null) {
				System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
				StringBuilder.Append(keyword.SPACE);
				StringBuilder.Append(keyword.LIMIT);
				StringBuilder.Append(keyword.SPACE);
				StringBuilder.Append(limit);
				return StringBuilder.ToString();
			}
			return System.String.Empty;
		}

		private System.String WHERE(System.String where = "") {
			if (!System.String.IsNullOrEmpty(where)) {
				System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
				StringBuilder.Append(keyword.SPACE);
				StringBuilder.Append(keyword.WHERE);
				StringBuilder.Append(keyword.SPACE);
				StringBuilder.Append(where);
				return StringBuilder.ToString();
			}
			return System.String.Empty;
		}


		public System.String SELECT(System.String where = "" , System.UInt32? limit = null) {
			System.Text.StringBuilder query = new System.Text.StringBuilder(255);
			query.Append(keyword.SELECT);
			query.Append(keyword.SPACE);
			query.Append(this.COLUMN());
			query.Append(keyword.SPACE);
			query.Append(keyword.FROM);
			query.Append(keyword.SPACE);
			query.Append(this.TABLE());
			query.Append(this.WHERE(where));
			query.Append(this.LIMIT(limit));
			query.Append(keyword.SEMICOLON);
			return query.ToString();
		}

		public System.String INSERT(System.String where = "" , System.UInt32? limit = null) {
			System.Text.StringBuilder query = new System.Text.StringBuilder(255);
			query.Append(keyword.SELECT);
			query.Append(keyword.SPACE);
			query.Append(this.COLUMN());
			query.Append(keyword.SPACE);
			query.Append(keyword.FROM);
			query.Append(keyword.SPACE);
			query.Append(this.TABLE());
			this.WHERE(where);
			this.LIMIT(limit);
			query.Append(keyword.SEMICOLON);
			return query.ToString();
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

		public System.Data.DataSet run(System.String query) {
			System.Data.DataSet DataSet = new System.Data.DataSet();
			using (MySql.Data.MySqlClient.MySqlConnection MySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(connection_string)) {
				using (MySql.Data.MySqlClient.MySqlCommand MySqlCommand = new MySql.Data.MySqlClient.MySqlCommand(query , MySqlConnection)) {
					using (MySql.Data.MySqlClient.MySqlDataAdapter MySqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(MySqlCommand)) {
						MySqlDataAdapter.Fill(DataSet);
					}
				}
			}
			return DataSet;
		}

	}
}