namespace Team3_Project.Databases.type {
	public class String : abstraction {
		public static String[] collection(subroutine subroutine , System.Object[] initialise) {
			return collection((abstraction item) => (String) item , () => new String() , subroutine , initialise);
		}
		public static String individual(subroutine subroutine , System.Object[] initialise) {
			return individual((abstraction item) => (String) item , () => new String() , subroutine , initialise);
		}
		public System.String value;
		public String() {
			this.value = System.String.Empty;
		}
		public String(System.String value) {
			this.value = value;
		}
		public override System.Boolean Equals(System.Object Object) {
			return this.value.Equals(Object);
		}
		public override System.Int32 GetHashCode() {
			return this.value.GetHashCode();
		}
		public override void cast(System.Object Object) {
			this.value = System.Convert.ToString(Object);
		}
		public override System.Boolean parse(System.String text) {
			this.value = text;
			return true;
		}
		public override System.String ToString() {
			return this.value.ToString();
		}
	}
}