namespace Team3_Project.Database.Movies {
	public class NameBasics : root {
		static NameBasics() {
			root.Table[typeof(NameBasics)] = new Tables("memdixyp_imdb" , "name_basics" , new System.String[] {
				"nconst" ,
				"primaryName",
				"birthYear",
				"deathYear",
				"primaryProfession",
				"knownForTitles"
			});
		}
		public System.String nconst;
		public System.String primaryName;
		public System.Int16? birthYear;
		public System.Int16? deathYear;
		public System.String primaryProfession;
		public System.String knownForTitles;
		public override System.Data.DataSet SELECT(System.String where = "" , System.UInt32? limit = null) {
			return this.run(root.Table[typeof(NameBasics)].SELECT(where , limit));
		}
		public override System.Data.DataSet INSERT() {
			throw new System.NotImplementedException();
		}
		public override System.String[] values() {
			return new System.String[] {
				this.nconst.ToString(),
				this.primaryName.ToString(),
				this.birthYear.ToString(),
				this.deathYear.ToString(),
				this.primaryProfession.ToString(),
				this.knownForTitles.ToString()
			};
		}
	}
}