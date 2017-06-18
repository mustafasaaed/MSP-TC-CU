using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LastDemo.Startup))]
namespace LastDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
