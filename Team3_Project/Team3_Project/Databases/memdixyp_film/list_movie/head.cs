namespace Team3_Project.Databases.memdixyp_film.list_movie {
	public static class head {
		public static readonly body body;
		static head() {
			body = new body();
		}
		public static body[] select_collection(System.String query) {
			return body.select_collection(query , (database item) => (body) item);
		}
		public static body select_individual(System.String query) {
			return body.select_individual(query , (database item) => (body) item);
		}
	}
}