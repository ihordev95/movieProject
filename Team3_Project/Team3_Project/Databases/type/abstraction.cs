namespace Team3_Project.Databases.type {
	public abstract class abstraction {
		private static System.String[] GetValues(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name) {
			System.String[] GetValues = NameValueCollection.GetValues(name);
			System.String value = GetValues != null && GetValues.Length >= 1 ? GetValues[0] : System.String.Empty;
			System.String[] values = value.Split(',');
			return values.Length > 0 ? values : new System.String[] { System.String.Empty };
		}
		private System.Collections.Generic.List<abstraction> work(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name) {
			System.Collections.Generic.List<abstraction> list = new System.Collections.Generic.List<abstraction>();
			System.String[] values = GetValues(NameValueCollection , name);
			foreach (System.String value in values) {
				abstraction item = this.constructor();
				item.parse(value);
				list.Add(item);
			}
			return list;
		}
		protected abstract abstraction constructor();
		public abstract void cast(System.Object Object);
		public abstract System.Boolean parse(System.String text);
		public void form(System.Collections.Specialized.NameValueCollection NameValueCollection , System.String name) {
			System.String[] GetValues = NameValueCollection.GetValues(name);
			this.parse(GetValues != null && GetValues.Length >= 1 ? GetValues[0] : System.String.Empty);
		}
		//
		public delegate System.Collections.Generic.List<abstraction> subroutine(System.Object[] initialise);
		public type[] collection<type>(System.Converter<abstraction , type> conversion , subroutine subroutine , System.Object[] initialise) {
			System.Collections.Generic.List<abstraction> list = subroutine.Invoke(initialise);
			abstraction[] array = list.ToArray();
			return System.Array.ConvertAll(array , conversion);
		}
		public type individual<type>(System.Converter<abstraction , type> conversion , subroutine subroutine , System.Object[] initialise) {
			System.Collections.Generic.List<abstraction> list = subroutine.Invoke(initialise);
			abstraction[] array = list.Count > 0 ? list.ToArray() : new abstraction[] { this.constructor() };
			return System.Array.ConvertAll(array , conversion)[0];
		}
		//
		public System.Collections.Generic.List<abstraction> do_work(System.Object[] initialise) {
			System.Collections.Generic.List<abstraction> list = new System.Collections.Generic.List<abstraction>();
			try {
				System.Collections.Specialized.NameValueCollection NameValueCollection = (System.Collections.Specialized.NameValueCollection) initialise[0];
				System.String name = (System.String) initialise[1];
				System.String[] values = GetValues(NameValueCollection , name);
				foreach (System.String value in values) {
					abstraction item = this.constructor();
					item.parse(value);
					list.Add(item);
				}
			}
			catch {
			}
			return list;
		}

	}
}