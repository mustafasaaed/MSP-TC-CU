using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ViewDemo.Startup))]
namespace ViewDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
