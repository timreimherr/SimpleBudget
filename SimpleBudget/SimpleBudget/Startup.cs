using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleBudget.Startup))]
namespace SimpleBudget
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
