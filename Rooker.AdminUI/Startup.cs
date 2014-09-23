using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PubRookie.AdminUI.Startup))]
namespace PubRookie.AdminUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
