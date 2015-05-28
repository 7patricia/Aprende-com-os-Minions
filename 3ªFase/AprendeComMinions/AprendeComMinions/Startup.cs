using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AprendeComMinions.Startup))]
namespace AprendeComMinions
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
