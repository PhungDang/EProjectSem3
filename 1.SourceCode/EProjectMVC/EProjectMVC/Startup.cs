using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EProjectMVC.Startup))]
namespace EProjectMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
