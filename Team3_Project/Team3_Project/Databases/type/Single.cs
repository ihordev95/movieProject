namespace Team3_Project.Databases.type {
	public class Single : abstraction {
		public static Single[] collection(subroutine subroutine , System.Object[] initialise) {
			return collection((superclass item) => (Single) item , () => new Single() , subroutine , initialise);
		}
		public static Single individual(subroutine subroutine , System.Object[] initialise) {
			return individual((superclass item) => (Single) item , () => new Single() , subroutine , initialise);
		}
		public System.Single value;
		public Single() {
			this.value = 0;
		}
		public Single(System.Single value) {
			this.value = value;
		}
		public override System.Boolean Equals(System.Object Object) {
			return this.value.Equals(Object);
		}
		public override System.Int32 GetHashCode() {
			return this.value.GetHashCode();
		}
		public override void cast(System.Object Object) {
			this.value = System.Convert.ToSingle(Object);
		}
		public override System.Boolean parse(System.String text) {
			return System.Single.TryParse(text , out this.value);
		}
		public override System.String ToString() {
			return this.value.ToString();
		}
	}
}