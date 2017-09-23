using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPNetIdentityTemplate.Startup))]
namespace ASPNetIdentityTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
