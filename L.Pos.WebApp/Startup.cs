using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L.Pos.WebApp.Startup))]
namespace L.Pos.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
