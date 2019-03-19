namespace Team3_Project.Databases.memdixyp_film {
	public class list_follow :  database {
		public System.Int32 user;
		public System.Int32 list;
		public list_follow(System.Collections.Specialized.NameValueCollection NameValueCollection) {
			this.user = url.Int32(NameValueCollection , nameof(this.user));
			this.list = url.Int32(NameValueCollection , nameof(this.list));
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
		public override System.Object[] values() {
			return new System.Object[] {
				this.user,
				this.list
			};
		}
	}
}