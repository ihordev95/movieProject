namespace Team3_Project.database {
	static public class url {
		public static System.String String(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name) {
			System.String[] GetValues = NameValueCollection.GetValues(name);
			return GetValues != null && GetValues.Length >= 1 ? GetValues[0] : System.String.Empty;
		}
		public static System.Int32 Int32(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name) {
			System.String data = String(NameValueCollection , name);
			System.Int32 value;
			return System.Int32.TryParse(data , out value) ? value : 0;
		}
		public static System.Boolean Boolean(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name) {
			System.String data = String(NameValueCollection , name);
			System.Boolean value;
			return System.Boolean.TryParse(data , out value);
		}
	}
}