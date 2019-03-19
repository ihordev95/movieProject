namespace Team3_Project.Databases {
	public static class keyword {
		public const System.Char SPACE = (System.Char) 0x0020;
		public const System.Char APOSTROPHE = (System.Char) 0x0027;
		public const System.Char LEFT_PARENTHESIS = (System.Char) 0x0028;
		public const System.Char RIGHT_PARENTHESIS = (System.Char) 0x0029;
		public const System.Char COMMA = (System.Char) 0x002C;
		public const System.Char FULL_STOP = (System.Char) 0x002E;
		public const System.Char SEMICOLON = (System.Char) 0x003B;
		public const System.Char GRAVE_ACCENT = (System.Char) 0x0060;
		public const System.String SELECT = "SELECT";
		public const System.String FROM = "FROM";
		public const System.String LIMIT = "LIMIT";
		public const System.String WHERE = "WHERE";
		public const System.String INSERT = "INSERT";
		public const System.String INTO = "INTO";
		public const System.String VALUES = "VALUES";
		public static readonly System.String COMMA_SEPARATED = System.String.Concat(COMMA , SPACE);
	}
}