namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_akas : database {
		public static readonly title_akas self;
		private static readonly System.Converter<database , title_akas> converter;
		static title_akas() {
			self = new title_akas();
			converter = (database item) => (title_akas) item;
		}
		public type.String titleId;
		public type.Byte ordering;
		public type.String title;
		public type.String region;
		public type.String language;
		public type.String types;
		public type.String attributes;
		public type.Boolean isOriginalTitle;
		public title_akas() {
			this.titleId = new type.String();
			this.ordering = new type.Byte();
			this.title = new type.String();
			this.region = new type.String();
			this.language = new type.String();
			this.types = new type.String();
			this.attributes = new type.String();
			this.isOriginalTitle = new type.Boolean();
		}
		protected override database constructor() {
			return new title_akas();
		}
		protected override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		protected override System.String table() {
			return nameof(title_akas);
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.titleId),
				nameof(this.ordering),
				nameof(this.title),
				nameof(this.region),
				nameof(this.language),
				nameof(this.types),
				nameof(this.attributes),
				nameof(this.isOriginalTitle)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.titleId,
				this.ordering,
				this.title,
				this.region,
				this.language,
				this.types,
				this.attributes,
				this.isOriginalTitle
			};
		}
	}
}