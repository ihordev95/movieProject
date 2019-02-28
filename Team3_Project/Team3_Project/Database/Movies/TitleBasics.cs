namespace Team3_Project.Database.Movies {
	public class TitleBasics : root {
		static TitleBasics() {
			root.Table[typeof(TitleBasics)] = new Tables("memdixyp_imdb" , "title_basics" , new System.String[] {
				"tconst",
				"titleType",
				"primaryTitle",
				"originalTitle",
				"isAdult",
				"startYear",
				"endYear",
				"runtimeMinutes",
				"genres"
			});
		}
		public override System.Data.DataSet SELECT(System.String where = "" , System.UInt32? limit = null) {
			return this.run(root.Table[typeof(TitleBasics)].SELECT(where , limit));
		}
		public override System.Data.DataSet INSERT() {
			throw new System.NotImplementedException();
		}
		public override System.String[] values() {
			throw new System.NotImplementedException();
		}
	}
}