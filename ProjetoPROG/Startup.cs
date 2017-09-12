using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoPROG.Startup))]
namespace ProjetoPROG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
