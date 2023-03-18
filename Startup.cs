using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyInsuranceApp.Startup))]
namespace MyInsuranceApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
