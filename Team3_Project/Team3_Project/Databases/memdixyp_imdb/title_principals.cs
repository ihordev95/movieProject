namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_principals : database {
		public static readonly title_principals self;
		static title_principals() {
			self = new title_principals();
		}
		public type.String tconst;
		public type.Int16 ordering;
		public type.String nconst;
		public type.String category;
		public type.String job;
		public type.String characters;
		public title_principals() {
			this.tconst = new type.String();
			this.ordering = new type.Int16();
			this.nconst = new type.String();
			this.category = new type.String();
			this.job = new type.String();
			this.characters = new type.String();
		}
		public override database constructor() {
			return new title_principals();
		}
		public override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		public override System.String table() {
			return nameof(title_principals);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.ordering),
				nameof(this.nconst),
				nameof(this.category),
				nameof(this.job),
				nameof(this.characters)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.tconst,
				this.ordering,
				this.nconst,
				this.category,
				this.job,
				this.characters
			};
		}
		public override database result(System.Data.DataRow DataRow) {
			return this;
		}
	}
}