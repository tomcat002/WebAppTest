using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppTest.Startup))]
namespace WebAppTest
{
    public partial class Startup
    {
        //Eric Test
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
