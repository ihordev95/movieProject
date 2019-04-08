namespace Team3_Project.Databases.type {
	public class Int16 : abstraction {
		public static Int16[] collection(subroutine subroutine , System.Object[] initialize) {
			return collection((superclass item) => (Int16) item , () => new Int16() , subroutine , initialize);
		}
		public static Int16 individual(subroutine subroutine , System.Object[] initialize) {
			return individual((superclass item) => (Int16) item , () => new Int16() , subroutine , initialize);
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
			if (Object != System.DBNull.Value) {
				this.value = System.Convert.ToInt16(Object);
			}
		}
		public override System.Boolean parse(System.String text) {
			return System.Int16.TryParse(text , out this.value);
		}
		public override System.String ToString() {
			return this.value.ToString();
		}
	}
}