namespace Team3_Project.database {
	static public class url {
		public static System.String name_value(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name) {
			System.String[] GetValues = NameValueCollection.GetValues(name);
			return GetValues != null && GetValues.Length >= 1 ? GetValues[0] : System.String.Empty;
		}
	}
}