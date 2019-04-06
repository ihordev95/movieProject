namespace Team3_Project.Databases.type {
	public abstract class abstraction {
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
		//
		public delegate abstraction constructor();
		public delegate System.Collections.Generic.List<abstraction> subroutine(constructor constructor , System.Object[] initialise);
		public static type[] collection<type>(System.Converter<abstraction , type> conversion , constructor constructor , subroutine subroutine , System.Object[] initialise) {
			System.Collections.Generic.List<abstraction> list = subroutine.Invoke(constructor , initialise);
			abstraction[] array = list.ToArray();
			return System.Array.ConvertAll(array , conversion);
		}
		public static type individual<type>(System.Converter<abstraction , type> conversion , constructor constructor , subroutine subroutine , System.Object[] initialise) {
			System.Collections.Generic.List<abstraction> list = subroutine.Invoke(constructor , initialise);
			abstraction[] array = list.Count > 0 ? list.ToArray() : new abstraction[] { constructor.Invoke() };
			return System.Array.ConvertAll(array , conversion)[0];
		}
		//
		public static System.Collections.Generic.List<abstraction> do_work(constructor constructor , System.Object[] initialise) {
			System.Collections.Generic.List<abstraction> list = new System.Collections.Generic.List<abstraction>();
			try {
				System.Collections.Specialized.NameValueCollection NameValueCollection = (System.Collections.Specialized.NameValueCollection) initialise[0];
				System.String name = (System.String) initialise[1];
				System.String[] values = GetValues(NameValueCollection , name);
				foreach (System.String value in values) {
					abstraction item = constructor.Invoke();
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