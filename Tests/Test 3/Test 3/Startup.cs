using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test_3.Startup))]
namespace Test_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
