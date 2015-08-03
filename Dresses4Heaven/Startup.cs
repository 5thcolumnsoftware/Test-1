using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dresses4Heaven.Startup))]
namespace Dresses4Heaven
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
