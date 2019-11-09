using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DevAppGetHelp.Startup))]
namespace DevAppGetHelp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
