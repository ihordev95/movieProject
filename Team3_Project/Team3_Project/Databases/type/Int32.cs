namespace Team3_Project.Databases.type {
	public class Int32 : abstraction {
		private System.Int32 value;
		public Int32() {
			this.value = 0;
		}
		public override System.Boolean Equals(System.Object Object) {
			return this.value.Equals(Object);
		}
		public override System.Int32 GetHashCode() {
			return this.value.GetHashCode();
		}
		public override void load(System.Data.DataRow DataRow , System.Int32 index) {
			this.value = (System.Int32) DataRow[index];
		}
		public override System.Boolean parse(System.String text) {
			return System.Int32.TryParse(text , out this.value);
		}
		public override System.String ToString() {
			return this.value.ToString();
		}
	}
}