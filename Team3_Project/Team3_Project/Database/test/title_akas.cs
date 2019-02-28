namespace Team3_Project.Database.memdixyp_imdb {
	public class title_akas : root {
		public System.String titleId;
		public System.Byte orderig;
		public System.String title;
		public System.String region;
		public System.String language;
		public System.String types;
		public System.String attributes;
		public System.Boolean isOriginalTitle;
		public override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		public override System.String table() {
			return nameof(title_akas);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.titleId),
				nameof(this.orderig),
				nameof(this.title),
				nameof(this.region),
				nameof(this.language),
				nameof(this.types),
				nameof(this.attributes),
				nameof(this.isOriginalTitle)
			};
		}
		public override System.Object[] values() {
			return new System.Object[] {
				this.titleId,
				this.orderig,
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