namespace Team3_Project.Databases.type {
	public class Byte : abstraction {
		private System.Byte value;
		public Byte() {
			this.value = 0;
		}
		public override void load(System.Data.DataRow DataRow , System.Int32 index) {
			this.value = (System.Byte) DataRow[index];
		}
		public override System.Boolean parse(System.String text) {
			return System.Byte.TryParse(text , out this.value);
		}
	}
}