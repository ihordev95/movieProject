namespace Team3_Project.Databases.type {
	public class Int16 : abstraction {
		private static readonly System.Converter<abstraction , Int16> converter;
		public static readonly Int16 self;
		static Int16() {
			converter = (abstraction item) => (Int16) item;
			self = new Int16();
		}
		public System.Int16 value;
		public Int16() {
			this.value = 0;
		}
		public Int16(System.Int16 value) {
			this.value = value;
		}
		public override System.Boolean Equals(System.Object Object) {
			return this.value.Equals(Object);
		}
		public override System.Int32 GetHashCode() {
			return this.value.GetHashCode();
		}
		public override void cast(System.Object Object) {
			this.value = System.Convert.ToInt16(Object);
		}
		public override System.Boolean parse(System.String text) {
			return System.Int16.TryParse(text , out this.value);
		}
		public override System.String ToString() {
			return this.value.ToString();
		}
	}
}