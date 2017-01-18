using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asp.net_admin_site_template.Startup))]
namespace asp.net_admin_site_template
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
