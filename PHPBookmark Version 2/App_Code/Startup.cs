using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PHPBookmark_Version_2.Startup))]
namespace PHPBookmark_Version_2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
