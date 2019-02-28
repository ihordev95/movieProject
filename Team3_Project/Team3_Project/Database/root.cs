namespace Team3_Project.Database {
	public abstract class root {
		protected static System.Collections.Generic.Dictionary<System.Type , Tables> Table;
		private static readonly System.String connection_string;
		static root() {
			Table = new System.Collections.Generic.Dictionary<System.Type , Tables>();
			//
			MySql.Data.MySqlClient.MySqlConnectionStringBuilder MySqlConnectionStringBuilder = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder {
				Server = "memdixyp.mysql.db.hostpoint.ch" ,
				UserID = "memdixyp_user" ,
				Password = "rmpvzSp4BsNm" ,
				SslMode = MySql.Data.MySqlClient.MySqlSslMode.None
			};
			connection_string = MySqlConnectionStringBuilder.ToString();
		}
		public abstract System.Data.DataSet SELECT(System.String where , System.UInt32? limit);
		public abstract System.Data.DataSet INSERT();
		public abstract System.String[] values();
		private System.String log = System.String.Empty;
		private System.String error = System.String.Empty;
		public System.Data.DataSet run(System.String query) {
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
	}
}