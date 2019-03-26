namespace Team3_Project.Databases.type {
	public class Int16 : abstraction {
		private System.Int16 value;
		public Int16() {
			this.value = 0;
		}
		public override void load(System.Data.DataRow DataRow , System.Int32 index) {
			this.value = (System.Int16) DataRow[index];
		}
		public override System.Boolean parse(System.String text) {
			return System.Int16.TryParse(text , out this.value);
		}
	}
}