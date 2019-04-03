namespace Team3_Project.Databases.memdixyp_film.list_follow {
	public class body : database {
		public type.Int32 user;
		public type.Int32 list;
		public body() {
			this.user = new type.Int32();
			this.list = new type.Int32();
		}
		public body(System.Collections.Specialized.NameValueCollection NameValueCollection) : this() {
			this.user.form(NameValueCollection , nameof(this.user));
			this.list.form(NameValueCollection , nameof(this.list));
		}
		public override database constructor() {
			return new body();
		}
		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(body);
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