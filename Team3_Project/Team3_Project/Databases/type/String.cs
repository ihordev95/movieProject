namespace Team3_Project.Databases.type {
	public class String : abstraction {
		private System.String value;
		public String() {
			this.value = System.String.Empty;
		}
		public override void load(System.Data.DataRow DataRow , System.Int32 index) {
			this.value = (System.String) DataRow[index];
		}
		public override System.Boolean parse(System.String text) {
			this.value = text;
			return true;
		}
	}
}