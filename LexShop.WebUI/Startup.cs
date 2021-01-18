using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BicycleShop.WebUI.Startup))]
namespace BicycleShop.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
