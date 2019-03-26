namespace Team3_Project.Databases.type {
	public class Single : abstraction {
		private System.Single value;
		public Single() {
			this.value = 0;
		}
		public override System.Boolean Equals(System.Object Object) {
			return this.value.Equals(Object);
		}
		public override System.Int32 GetHashCode() {
			return this.value.GetHashCode();
		}
		public override void load(System.Data.DataRow DataRow , System.Int32 index) {
			this.value = (System.Single) DataRow[index];
		}
		public override System.Boolean parse(System.String text) {
			return System.Single.TryParse(text , out this.value);
		}
		public override System.String ToString() {
			return this.value.ToString();
		}
	}
}