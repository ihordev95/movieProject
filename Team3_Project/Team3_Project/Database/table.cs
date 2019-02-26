namespace Team3_Project.Database {
	public class Table {
		private static System.String[] prefix_array(System.String prefix , System.String[] array) {
			System.Int32 index = array.Length;
			System.String[] result = new System.String[index];
			while (index > 0) {
				index -= 1;
				result[index] = System.String.Concat(prefix , array[index]);
			}
			return result;
		}
		public readonly System.String schema;
		public readonly System.String table;
		public readonly System.String column;
		public readonly System.String select;
		public readonly System.String insert;
		public Table(System.String schema , System.String table , System.String[] column) {
			this.schema = schema;
			this.table = System.String.Concat(this.schema , '.' , table);
			System.String prefix = System.String.Concat(this.table , ".");
			System.String[] result = prefix_array(prefix , column);
			this.column = System.String.Join(", " , result);
			this.select = System.String.Concat(new System.String[] {
				"SELECT ",
				this.column,
				" FROM ",
				this.table
			});
			this.insert = System.String.Concat(new System.String[] {
				"INSERT INTO ",
				this.table,
				" (",
				this.column,
				")"
			});
		}
		private System.String limit(System.UInt32? limit = null) {
			return limit == null ? System.String.Empty : System.String.Concat(" LIMIT " , limit);
		}
		private System.String where(System.String where = "") {
			return System.String.IsNullOrEmpty(where) ? System.String.Empty : System.String.Concat(" WHERE " , where);
		}
		public System.String SELECT(System.String where = "" , System.UInt32? limit = null) {
			return System.String.Concat(this.select , this.where(where) , this.limit(limit) , ';');
		}
		public System.String INSERT(Database data ) {
			return System.String.Concat(this.insert, " VALUES (", data.values(), ");");
		}

	}
}