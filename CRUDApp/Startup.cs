using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDApp.Startup))]
namespace CRUDApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
