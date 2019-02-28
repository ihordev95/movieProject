namespace Team3_Project.Database {
	public abstract class root {
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
			System.Text.StringBuilder StringBuilder = new System.Text.StringBuilder();
			foreach (System.String column in columns) {
				StringBuilder.Append(this.QUALIFY_IDENTIFIER(table , this.QUOTE_IDENTIFIER(column)));
			}
			return System.String.Join(keyword.COMMA_SEPARATED , StringBuilder.ToString());
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
			this.WHERE(where);
			this.LIMIT(limit);
			return query.ToString();
		}
	}
}