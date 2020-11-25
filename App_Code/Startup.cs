using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(POEWebSite.Startup))]
namespace POEWebSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
