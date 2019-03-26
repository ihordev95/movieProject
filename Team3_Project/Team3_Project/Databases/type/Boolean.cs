namespace Team3_Project.Databases.type {
	public class Boolean : abstraction {
		private System.Boolean value;
		public Boolean() {
			this.value = false;
		}
		public override void load(System.Data.DataRow DataRow , System.Int32 index) {
			this.value = (System.Boolean) DataRow[index];
		}
		public override System.Boolean parse(System.String text) {
			return System.Boolean.TryParse(text , out this.value);
		}
	}
}