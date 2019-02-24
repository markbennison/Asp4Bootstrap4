using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asp4Bootstrap4.Startup))]
namespace Asp4Bootstrap4
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
