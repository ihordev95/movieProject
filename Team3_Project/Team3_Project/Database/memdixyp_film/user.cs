namespace Team3_Project.database.memdixyp_film {
	public class user : database {
		public System.Int32 identifier;
		public System.String name;
		public System.String password;
		public System.String email;
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
		public override System.Object[] values() {
			return new System.Object[] {
				this.identifier,
				this.name,
				this.password,
				this.email
			};
		}
	}
}