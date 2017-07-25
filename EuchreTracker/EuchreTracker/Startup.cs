using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EuchreTracker.Startup))]
namespace EuchreTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
