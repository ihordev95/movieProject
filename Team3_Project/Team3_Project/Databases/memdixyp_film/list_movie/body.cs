namespace Team3_Project.Databases.memdixyp_film.list_movie {
	public class body : database {
		public type.Int32 list;
		public type.String movie;
		public type.DateTime added;
		public body() {
			this.list = new type.Int32();
			this.movie = new type.String();
			this.added = new type.DateTime();
		}
		public body(System.Collections.Specialized.NameValueCollection NameValueCollection) : this() {
			this.list.form(NameValueCollection , nameof(this.list));
			this.movie.form(NameValueCollection , nameof(this.movie));
			this.added.form(NameValueCollection , nameof(this.added));
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
				nameof(this.list),
				nameof(this.movie),
				nameof(this.added)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.list,
				this.movie,
				this.added
			};
		}
	}
}