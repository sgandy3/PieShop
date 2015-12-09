using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PieShop.Startup))]
namespace PieShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
