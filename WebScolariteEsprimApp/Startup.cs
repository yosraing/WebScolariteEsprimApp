using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebScolariteEsprimApp.Startup))]
namespace WebScolariteEsprimApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
