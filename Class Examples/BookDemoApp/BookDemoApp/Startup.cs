using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookDemoApp.Startup))]
namespace BookDemoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
