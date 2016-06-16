using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TwoStepAuthentication.Startup))]
namespace TwoStepAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
