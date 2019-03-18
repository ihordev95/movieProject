namespace Team3_Project.database.memdixyp_film {
	public class list_film :  database {
		public System.Int32 list;
		public System.Int32 film;
		public list_film(System.Collections.Specialized.NameValueCollection NameValueCollection) {
			this.list = url.Int32(NameValueCollection , "list");
			this.film = url.Int32(NameValueCollection , "film");
		}
		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(list_film);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.list),
				nameof(this.film)
			};
		}
		public override System.Object[] values() {
			return new System.Object[] {
				this.list,
				this.film
			};
		}
	}
}