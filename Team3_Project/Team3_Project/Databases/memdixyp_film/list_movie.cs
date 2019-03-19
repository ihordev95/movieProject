namespace Team3_Project.Databases.memdixyp_film {
	public class list_movie :  database {
		public System.Int32 list;
		public System.Int32 movie;
		public System.Boolean archive;
		public list_movie(System.Collections.Specialized.NameValueCollection NameValueCollection) {
			this.list = url.Int32(NameValueCollection , nameof(this.list));
			this.movie = url.Int32(NameValueCollection , nameof(this.movie));
			this.archive = url.Boolean(NameValueCollection , nameof(this.archive));
		}
		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(list_movie);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.list),
				nameof(this.movie),
				nameof(this.archive)
			};
		}
		public override System.Object[] values() {
			return new System.Object[] {
				this.list,
				this.movie,
				this.archive
			};
		}
	}
}