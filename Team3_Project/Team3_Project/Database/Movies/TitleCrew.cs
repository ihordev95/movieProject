namespace Team3_Project.Database.Movies {
	public class TitleCrew : Database {
		static TitleCrew() {
			Database.Table[typeof(TitleCrew)] = new Table("memdixyp_imdb" , "title_crew" , new System.String[] {
				"tconst",
				"directors",
				"writers" 
			});
		}
		public override System.Data.DataSet SELECT(System.String where = "" , System.UInt32? limit = null) {
			return this.run(Database.Table[typeof(TitleCrew)].SELECT(where , limit));
		}
		public override System.Data.DataSet INSERT() {
			throw new System.NotImplementedException();
		}
		public override System.String[] values() {
			throw new System.NotImplementedException();
		}
	}
}