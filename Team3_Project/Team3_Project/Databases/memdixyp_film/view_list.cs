namespace Team3_Project.Databases.memdixyp_film {
	public class view_list : procedure {
		public System.Int32 identifier;
		public view_list(System.Int32 identifier) {
			this.identifier = identifier;
		}
		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(view_list);
		}
		public override System.Object[] values() {
			return new System.Object[] {
				this.identifier
			};
		}
	}
}