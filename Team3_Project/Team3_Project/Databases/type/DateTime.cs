namespace Team3_Project.Databases.type {
	public class DateTime : abstraction {
		private static readonly System.Converter<abstraction , DateTime> converter;
		public static readonly DateTime self;
		static DateTime() {
			converter = (abstraction item) => (DateTime) item;
			self = new DateTime();
		}
		protected override abstraction constructor() {
			return new DateTime();
		}
		public System.DateTime value;
		public DateTime() {
			this.value = System.DateTime.UtcNow;
		}
		public DateTime(System.DateTime value) {
			this.value = value;
		}
		public override System.Boolean Equals(System.Object Object) {
			return this.value.Equals(Object);
		}
		public override System.Int32 GetHashCode() {
			return this.value.GetHashCode();
		}
		public override void cast(System.Object Object) {
			this.value = System.Convert.ToDateTime(Object);
		}
		public override System.Boolean parse(System.String text) {
			return System.DateTime.TryParse(text , out this.value);
		}
		public override System.String ToString() {
			return this.value.ToString();
		}
	}
}