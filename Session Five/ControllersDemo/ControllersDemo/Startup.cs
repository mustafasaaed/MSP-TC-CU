using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControllersDemo.Startup))]
namespace ControllersDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
