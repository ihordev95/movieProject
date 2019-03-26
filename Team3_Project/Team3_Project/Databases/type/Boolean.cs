namespace Team3_Project.Databases.type {
	public class Boolean : abstraction {
		private System.Boolean value;
		public Boolean() {
			this.value = false;
		}
		public Boolean(System.Boolean value) {
			this.value = value;
		}
		public override System.Boolean Equals(System.Object Object) {
			return this.value.Equals(Object);
		}
		public override System.Int32 GetHashCode() {
			return this.value.GetHashCode();
		}
		public override void load(System.Data.DataRow DataRow , System.Int32 index) {
			this.value = (System.Boolean) DataRow[index];
		}
		public override System.Boolean parse(System.String text) {
			return System.Boolean.TryParse(text , out this.value);
		}
		public override System.String ToString() {
			return this.value.ToString();
		}
	}
}