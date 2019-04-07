namespace Team3_Project.Databases.memdixyp_imdb {
	public class title_crew : database {
		private static readonly System.Converter<database , title_crew> converter;
		public static readonly title_crew self;
		static title_crew() {
			converter = (database item) => (title_crew) item;
			self = new title_crew();
		}
		public static title_crew[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (title_crew) item , () => new title_crew() , subroutine , initialize);
		}
		public static title_crew individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (title_crew) item , () => new title_crew() , subroutine , initialize);
		}
		public type.String tconst;
		public type.String directors;
		public type.String writers;
		private title_crew() {
			this.tconst = new type.String();
			this.directors = new type.String();
			this.writers = new type.String();
		}
		protected override database data_fill() {
			return new title_crew();
		}
		protected override System.String schema() {
			return nameof(memdixyp_imdb);
		}
		protected override System.String table() {
			return nameof(title_crew);
		}
		protected override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.directors),
				nameof(this.writers)
			};
		}
		protected override type.abstraction[] values() {
			return new type.abstraction[] {
				this.tconst,
				this.directors,
				this.writers
			};
		}
	}
}