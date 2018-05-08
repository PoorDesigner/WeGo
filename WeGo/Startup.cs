using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeGo.Startup))]
namespace WeGo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
