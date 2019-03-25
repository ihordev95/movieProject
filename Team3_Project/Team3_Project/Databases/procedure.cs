namespace Team3_Project.Databases {
	public abstract class procedure : database {
		public override System.String[] columns() {
			throw new System.NotImplementedException();
		}
		public abstract override System.String schema();
		public abstract override System.String table();
		public abstract override System.Object[] values();
		public System.Data.DataSet CALL() {
			System.Text.StringBuilder query = new System.Text.StringBuilder(255);
			query.Append(keyword.CALL);
			query.Append(unicode.SPACE);
			query.Append(this.TABLE());
			query.Append(unicode.SPACE);
			query.Append(unicode.LEFT_PARENTHESIS);
			query.Append(this.VALUES());
			query.Append(unicode.RIGHT_PARENTHESIS);
			query.Append(unicode.SEMICOLON);
			return this.run(query.ToString());
		}
	}
}