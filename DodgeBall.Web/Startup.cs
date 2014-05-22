using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DodgeBall.Web.Startup))]
namespace DodgeBall.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
