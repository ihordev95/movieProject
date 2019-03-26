namespace Team3_Project.Databases.memdixyp_film {
	public class view_list : database {
		public type.String tconst;
		public type.String primaryTitle;
		public type.Int16 startYear;

		public System.Int32 identifier;
		public view_list(System.Int32 identifier) {
			this.identifier = identifier;
		}


		public override System.String schema() {
			return nameof(memdixyp_film);
		}
		public override System.String table() {
			return nameof(view_list);
		}

		public override System.String[] columns() {
			return new System.String[] {
				nameof(this.tconst),
				nameof(this.primaryTitle),
				nameof(this.startYear)
			};
		}
		public override type.abstraction[] values() {
			return new type.abstraction[] {
				this.tconst,
				this.primaryTitle,
				this.startYear
			};
		}
		/*
		public override System.Object[] parameters() {
			return new System.Object[] {
				this.identifier
			};
		}
*/
		public void load(System.Data.DataRow DataRow) {
			this.tconst.load(DataRow , 0);
			this.primaryTitle.load(DataRow , 1);
			this.startYear.load(DataRow , 2);
		}
	}
}