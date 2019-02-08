using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Team3_Project.Startup))]
namespace Team3_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
