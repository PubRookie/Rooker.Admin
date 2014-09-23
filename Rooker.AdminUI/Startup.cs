using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rooker.AdminUI.Startup))]
namespace Rooker.AdminUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
