namespace Team3_Project.Databases {
	public static class parse {
		public static System.Int32 Int32(System.String text , System.Int32 fallback) {
			System.Int32 value;
			return System.Int32.TryParse(text , out value) ? value : fallback;
		}
	}
}