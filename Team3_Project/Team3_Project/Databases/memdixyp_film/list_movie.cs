﻿namespace Team3_Project.Databases.memdixyp_film {
	public class list_movie :  database {
		public type.Int32 list;
		public type.Int32 movie;
		public type.Boolean archive;
		public list_movie(System.Collections.Specialized.NameValueCollection NameValueCollection) {
			this.list.form(NameValueCollection , nameof(this.list));
			this.movie.form(NameValueCollection , nameof(this.movie));
			this.archive.form(NameValueCollection , nameof(this.archive));
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
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.list,
				this.movie,
				this.archive
			};
		}
	}
}