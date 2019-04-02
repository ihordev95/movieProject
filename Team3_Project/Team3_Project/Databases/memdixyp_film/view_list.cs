namespace Team3_Project.Databases.memdixyp_film {
	public class view_list : database {
		public type.Int32 list;
		public type.String tconst;
		public type.String primaryTitle;
		public type.Int16 startYear;
		public view_list() {
			this.list = new type.Int32();
			this.tconst = new type.String();
			this.primaryTitle = new type.String();
			this.startYear = new type.Int16();
		}
		public view_list(System.Int32 list) : this() {
			this.list = new type.Int32(list);
		}
		public override database constructor() {
			return new view_list();
		}
		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(view_list);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.list),
				nameof(this.tconst),
				nameof(this.primaryTitle),
				nameof(this.startYear)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.list,
				this.tconst,
				this.primaryTitle,
				this.startYear
			};
		}
		public override type.abstraction[] parameters() {
			return new type.abstraction[] {
				this.list
			};
		}
	}
}