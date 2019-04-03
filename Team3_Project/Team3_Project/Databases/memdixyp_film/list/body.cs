namespace Team3_Project.Databases.memdixyp_film {
	public partial class list : database {
		public type.Int32 identifier;
		public type.Int32 user;
		public type.String name;
		public type.Boolean hidden; public list() {
			this.identifier = new type.Int32();
			this.user = new type.Int32();
			this.name = new type.String();
			this.hidden = new type.Boolean();
		}
		public list(System.Collections.Specialized.NameValueCollection NameValueCollection) : this() {
			this.identifier.form(NameValueCollection , nameof(this.identifier));
			this.user.form(NameValueCollection , nameof(this.user));
			this.name.form(NameValueCollection , nameof(this.name));
			this.hidden.form(NameValueCollection , nameof(this.hidden));
		}
		public override database constructor() {
			return new list();
		}
		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(list);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.identifier),
				nameof(this.user),
				nameof(this.name),
				nameof(this.hidden)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.identifier,
				this.user,
				this.name,
				this.hidden
			};
		}
	}
}