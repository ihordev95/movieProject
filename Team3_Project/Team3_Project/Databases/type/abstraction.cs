namespace Team3_Project.Databases.type {
	public abstract class abstraction {
		private static System.String[] GetValues(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name) {
			System.String[] GetValues = NameValueCollection.GetValues(name);
			System.String value = GetValues != null && GetValues.Length >= 1 ? GetValues[0] : System.String.Empty;
			System.String[] values = value.Split(',');
			return values.Length > 0 ? values : new System.String[] { System.String.Empty };
		}
		protected abstract abstraction constructor();
		public abstract void cast(System.Object Object);
		public abstract System.Boolean parse(System.String text);
		public void form(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name) {
			System.String[] GetValues = NameValueCollection.GetValues(name);
			this.parse(GetValues != null && GetValues.Length >= 1 ? GetValues[0] : System.String.Empty);
		}
		private System.Collections.Generic.List<abstraction> subroutine(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name) {
			System.Collections.Generic.List<abstraction> list = new System.Collections.Generic.List<abstraction>();
			System.String[] values = GetValues(NameValueCollection , name);
			foreach (System.String value in values) {
				abstraction item = this.constructor();
				item.parse(value);
				list.Add(item);
			}
			return list;
		}
		protected type[] collection<type>(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name , System.Converter<abstraction , type> converter) {
			System.Collections.Generic.List<abstraction> list = this.subroutine(NameValueCollection, name);
			abstraction[] array = list.ToArray();
			return System.Array.ConvertAll(array , converter);
		}
		protected type individual<type>(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name , System.Converter<abstraction , type> converter) {
			System.Collections.Generic.List<abstraction> list = this.subroutine(NameValueCollection, name);
			abstraction[] array = list.Count > 0 ? list.ToArray() : new abstraction[] { this.constructor() };
			return System.Array.ConvertAll(array , converter)[0];
		}
	}
}