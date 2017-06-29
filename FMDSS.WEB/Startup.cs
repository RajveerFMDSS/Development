using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FMDSS.WEB.Startup))]
namespace FMDSS.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
