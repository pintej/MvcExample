using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NetMvcExample.Startup))]
namespace NetMvcExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
