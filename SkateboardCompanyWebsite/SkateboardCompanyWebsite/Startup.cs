using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SkateboardCompanyWebsite.Startup))]
namespace SkateboardCompanyWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
