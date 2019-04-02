namespace Team3_Project.Databases.memdixyp_film {
	public class list_follow : database {
		public static readonly list_follow self;
		static list_follow() {
			self = new list_follow();
		}
		public static list_follow select(System.String where = "" , System.UInt32? limit = null) {
			list_follow list_follow = new list_follow();
			System.Data.DataSet data = list_follow.SELECT(where , limit);
			System.Data.DataRow DataRow = data.Tables[0].Rows[0];
			return (list_follow) list_follow.result(DataRow);
		}
		public type.Int32 user;
		public type.Int32 list;
		public list_follow() {
			this.user = new type.Int32();
			this.list = new type.Int32();
		}
		public list_follow(System.Collections.Specialized.NameValueCollection NameValueCollection) : this() {
			this.user.form(NameValueCollection , nameof(this.user));
			this.list.form(NameValueCollection , nameof(this.list));
		}
		public override database constructor() {
			return new list_follow();
		}
		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(list_follow);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.user),
				nameof(this.list)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.user,
				this.list
			};
		}
		public override database result(System.Data.DataRow DataRow) {
			this.user.load(DataRow , 0);
			this.list.load(DataRow , 1);
			return this;
		}
	}
}