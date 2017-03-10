using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DSASS.Startup))]
namespace DSASS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
