using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthenticationProjectFinal.Startup))]
namespace AuthenticationProjectFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
