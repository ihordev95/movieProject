namespace Team3_Project.Databases.memdixyp_film {
	public class user : database {
		public type.Int32 identifier;
		public type.String name;
		public type.String password;
		public type.String email;
		public user (System.Collections.Specialized.NameValueCollection NameValueCollection) {
			this.identifier.form(NameValueCollection , nameof(this.identifier));
			this.name.form(NameValueCollection , nameof(this.name));
			this.password.form(NameValueCollection , nameof(this.password));
			this.email.form(NameValueCollection , nameof(this.email));
		}
		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(user);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.identifier),
				nameof(this.name),
				nameof(this.password),
				nameof(this.email)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.identifier,
				this.name,
				this.password,
				this.email
			};
		}
	}
}