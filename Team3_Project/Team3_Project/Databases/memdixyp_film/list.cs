	namespace Team3_Project.Databases.memdixyp_film {
	public class list : database {
		public System.Int32 identifier;
		public System.Int32 user;
		public System.String name;
		public System.Boolean hidden;
		public list(System.Collections.Specialized.NameValueCollection NameValueCollection) {
			this.identifier = url.Int32(NameValueCollection , "identifier");
			this.user = url.Int32(NameValueCollection , "user");
			this.name = url.String(NameValueCollection , "name");
			this.hidden = url.Boolean(NameValueCollection , "hidden");
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
		public override System.Object[] values() {
			return new System.Object[] {
				this.identifier,
				this.user,
				this.name,
				this.hidden
			};
		}
	}
}