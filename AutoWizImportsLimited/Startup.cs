using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutoWizImportsLimited.Startup))]
namespace AutoWizImportsLimited
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
