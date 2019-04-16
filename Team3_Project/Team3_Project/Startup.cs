[assembly: Microsoft.Owin.OwinStartupAttribute(typeof(Team3_Project.Startup))]
namespace Team3_Project {
	public partial class Startup {
		public void Configuration(Owin.IAppBuilder app) {
			this.ConfigureAuth(app);
		}
	}
}