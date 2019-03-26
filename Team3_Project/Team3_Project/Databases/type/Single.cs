namespace Team3_Project.Databases.type {
	public class Single : abstraction {
		private System.Single value;
		public Single() {
			this.value = 0;
		}
		public override void load(System.Data.DataRow DataRow , System.Int32 index) {
			this.value = (System.Single) DataRow[index];
		}
		public override System.Boolean parse(System.String text) {
			return System.Single.TryParse(text , out this.value);
		}
	}
}