using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bilijar.Startup))]
namespace bilijar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
