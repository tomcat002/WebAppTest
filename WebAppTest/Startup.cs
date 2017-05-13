using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppTest.Startup))]
namespace WebAppTest
{
    public partial class Startup
    {
        //5th comment
        //4th comment
        //another more comment
        //one more comment
        //Eric Test
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
