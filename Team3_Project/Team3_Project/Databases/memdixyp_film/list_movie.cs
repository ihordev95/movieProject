﻿namespace Team3_Project.Databases.memdixyp_film {
	public class list_movie : database {
		private static readonly System.Converter<database , list_movie> converter;
		public static readonly list_movie self;
		static list_movie() {
			converter = (database item) => (list_movie) item;
			self = new list_movie();
		}
		public type.Int32 list;
		public type.String movie;
		public type.DateTime added;
		private list_movie() {
			this.list = new type.Int32();
			this.movie = new type.String();
			this.added = new type.DateTime();
		}
		protected override database constructor() {
			return new list_movie();
		}
		protected override System.String schema() {
			return nameof(memdixyp_film);
		}
		protected override System.String table() {
			return nameof(list_movie);
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.list),
				nameof(this.movie),
				nameof(this.added)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.list,
				this.movie,
				this.added
			};
		}
		public static void insert_individual(System.Collections.Specialized.NameValueCollection NameValueCollection) {
			list_movie list_movie = new list_movie();
			list_movie.list.form(NameValueCollection , nameof(list_movie.list));
			list_movie.movie.form(NameValueCollection , nameof(list_movie.movie));
			list_movie.added.form(NameValueCollection , nameof(list_movie.added));
			insert(list_movie);
		}
	}
}