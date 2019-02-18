namespace Team3_Project.Database {
	public abstract class Database {
		private readonly System.String connection_string;
		protected Database(System.String database) {
			MySql.Data.MySqlClient.MySqlConnectionStringBuilder MySqlConnectionStringBuilder = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder {
				Server = "memdixyp.mysql.db.hostpoint.ch" ,
				UserID = "memdixyp_user" ,
				Password = "rmpvzSp4BsNm" ,
				Database = database ,
				SslMode = MySql.Data.MySqlClient.MySqlSslMode.None
			};
			this.connection_string = MySqlConnectionStringBuilder.ToString();
		}
		protected System.Data.DataSet run(System.String query) {
			System.Data.DataSet DataSet = new System.Data.DataSet();
			using (MySql.Data.MySqlClient.MySqlConnection MySqlConnection = new MySql.Data.MySqlClient.MySqlConnection(this.connection_string)) {
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