namespace Team3_Project.Databases.type {
	public abstract class abstraction : superclass {
		private static System.String[] GetValues(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name) {
			System.String[] GetValues = NameValueCollection.GetValues(name);
			System.String value = GetValues != null && GetValues.Length >= 1 ? GetValues[0] : System.String.Empty;
			System.String[] values = value.Split(',');
			return values.Length > 0 ? values : new System.String[] { System.String.Empty };
		}
		public abstract void cast(System.Object Object);
		public abstract System.Boolean parse(System.String text);
		public void form(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name) {
			System.String[] GetValues = NameValueCollection.GetValues(name);
			this.parse(GetValues != null && GetValues.Length >= 1 ? GetValues[0] : System.String.Empty);
		}
		public static System.Collections.Generic.List<superclass> form(constructor constructor , System.Object[] initialise) {
			System.Collections.Specialized.NameValueCollection NameValueCollection;
			System.String name;
			try {
				NameValueCollection = (System.Collections.Specialized.NameValueCollection) initialise[0];
				name = (System.String) initialise[1];
			}
			catch {
				throw new System.ArgumentException();
			}
			System.Collections.Generic.List<superclass> list = new System.Collections.Generic.List<superclass>();
			System.String[] values = GetValues(NameValueCollection , name);
			foreach (System.String value in values) {
				abstraction item = (abstraction) constructor.Invoke();
				item.parse(value);
				list.Add(item);
			}
			return list;
		}
	}
}