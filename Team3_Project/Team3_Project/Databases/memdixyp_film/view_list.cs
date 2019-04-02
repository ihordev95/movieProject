namespace Team3_Project.Databases.memdixyp_film {
	public class view_list : database {
		public static view_list make(System.Data.DataRow DataRow) {
			return new view_list(DataRow);
		}
		public type.Int32 identifier;
		public type.String tconst;
		public type.String primaryTitle;
		public type.Int16 startYear;
		public view_list() {
			this.identifier = new type.Int32();
			this.tconst = new type.String();
			this.primaryTitle = new type.String();
			this.startYear = new type.Int16();
		}
		public view_list(System.Int32 identifier) : this() {
			this.identifier = new type.Int32(identifier);
		}
		public view_list(System.Data.DataRow DataRow) : this() {
			// this.identifier.load(DataRow , 0);
			this.tconst.load(DataRow , 0);
			this.primaryTitle.load(DataRow , 1);
			this.startYear.load(DataRow , 2);
		}
		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(view_list);
		}
		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.identifier),
				nameof(this.tconst),
				nameof(this.primaryTitle),
				nameof(this.startYear)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.identifier,
				this.tconst,
				this.primaryTitle,
				this.startYear
			};
		}
		public override type.abstraction[] parameters() {
			return new type.abstraction[] {
				this.identifier
			};
		}
		public override database result(System.Data.DataRow DataRow) {
			/*
			this.identifier.load(DataRow , 0);
			this.tconst.load(DataRow , 1);
			this.primaryTitle.load(DataRow , 2);
			this.identifier.load(DataRow , 3);
			*/
			this.tconst.load(DataRow , 0);
			this.primaryTitle.load(DataRow , 1);
			this.identifier.load(DataRow , 2);
			return this;
		}
	}
}