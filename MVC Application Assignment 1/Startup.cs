using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_Application_Assignment_1.Startup))]
namespace MVC_Application_Assignment_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
