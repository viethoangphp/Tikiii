using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tikiii.Startup))]
namespace Tikiii
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
