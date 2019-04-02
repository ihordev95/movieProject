namespace Team3_Project.Databases.type {
	public abstract class abstraction {
		public abstract void cast(System.Object Object);
		public abstract System.Boolean parse(System.String text);
		public void form(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name) {
			System.String[] GetValues = NameValueCollection.GetValues(name);
			this.parse(GetValues != null && GetValues.Length >= 1 ? GetValues[0] : System.String.Empty);
		}
	}
}