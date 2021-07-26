using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OWINAuthentication.Startup))]
namespace OWINAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
