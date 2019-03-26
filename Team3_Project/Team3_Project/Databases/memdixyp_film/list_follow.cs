namespace Team3_Project.Databases.memdixyp_film {
	public class list_follow :  database {
		public type.Int32 user;
		public type.Int32 list;
		public list_follow(System.Collections.Specialized.NameValueCollection NameValueCollection) {
			this.user.form(NameValueCollection , nameof(this.user));
			this.list.form(NameValueCollection , nameof(this.list));
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
	}
}