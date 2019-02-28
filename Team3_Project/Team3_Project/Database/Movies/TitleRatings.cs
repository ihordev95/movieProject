namespace Team3_Project.Database.Movies {
	public class TitleRatings : Database {
		static TitleRatings() {
			Database.Table[typeof(TitleRatings)] = new Tables("memdixyp_imdb" , "title_ratings" , new System.String[] {
				"tconst",
				"averageRating",
				"numVotes"
			});
		}
		public override System.Data.DataSet SELECT(System.String where = "" , System.UInt32? limit = null) {
			return this.run(Database.Table[typeof(TitleRatings)].SELECT(where , limit));
		}
		public override System.Data.DataSet INSERT() {
			throw new System.NotImplementedException();
		}
		public override System.String[] values() {
			throw new System.NotImplementedException();
		}
	}
}