namespace Team3_Project.Database.Movies {
	public class TitlePrincipals : Database {
		static TitlePrincipals() {
			Database.Table[typeof(TitlePrincipals)] = new Table("memdixyp_imdb" , "title_principals" , new System.String[] {
				"tconst",
				"ordering",
				"nconst",
				"category",
				"job",
				"characters"
			});
		}
		public override System.Data.DataSet SELECT(System.String where = "" , System.UInt32? limit = null) {
			return this.run(Database.Table[typeof(TitlePrincipals)].SELECT(where , limit));
		}
		public override System.Data.DataSet INSERT() {
			throw new System.NotImplementedException();
		}
		public override System.String[] values() {
			throw new System.NotImplementedException();
		}
	}
}