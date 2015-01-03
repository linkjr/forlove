using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tang.Mall.WebUI.Startup))]
namespace Tang.Mall.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
