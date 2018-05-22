using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GK.Startup))]
namespace GK
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
