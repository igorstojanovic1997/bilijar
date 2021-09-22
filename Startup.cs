using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(bilijar.Startup))]
namespace bilijar
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
