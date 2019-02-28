namespace Team3_Project.Database.Movies {
	public class TitleAkas : Database {
		static TitleAkas() {
			Database.Table[typeof(TitleAkas)] = new Tables("memdixyp_imdb" , "title_akas" , new System.String[] {
				"titleId",
				"ordering",
				"title",
				"region",
				"language",
				"types",
				"attributes",
				"isOriginalTitle"
			});
		}
		public System.String titleId;
		public System.Byte orderig;
		public System.String title;
		public System.String region;
		public System.String language;
		public System.String types;
		public System.String attributes;
		public System.Boolean isOriginalTitle;
		public override System.Data.DataSet SELECT(System.String where = "" , System.UInt32? limit = null) {
			return this.run(Database.Table[typeof(TitleAkas)].SELECT(where , limit));
		}
		public override System.Data.DataSet INSERT() {
			throw new System.NotImplementedException();
		}
		public override System.String[] values() {
			throw new System.NotImplementedException();
		}
	}
}