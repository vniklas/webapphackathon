using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webapphackathon.Startup))]
namespace webapphackathon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
