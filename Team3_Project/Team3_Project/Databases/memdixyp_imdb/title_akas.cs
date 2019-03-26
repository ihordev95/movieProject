namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_akas : database {
		public type.String titleId;
		public type.Byte ordering;
		public type.String title;
		public type.String region;
		public type.String language;
		public type.String types;
		public type.String attributes;
		public type.Boolean isOriginalTitle;
		public override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		public override System.String table() {
			return nameof(title_akas);
		}
		public override System.String[] columns() {
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
		public override type.abstraction[] values() {
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