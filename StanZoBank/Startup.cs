using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StanZoBank.Startup))]
namespace StanZoBank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
