using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OasisGaming.Startup))]
namespace OasisGaming
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
