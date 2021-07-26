using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StackOverFlow.Startup))]
namespace StackOverFlow
{
    
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
