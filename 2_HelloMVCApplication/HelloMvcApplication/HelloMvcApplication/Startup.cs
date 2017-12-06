using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloMvcApplication.Startup))]
namespace HelloMvcApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
