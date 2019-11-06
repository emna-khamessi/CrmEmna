using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrmEmna.Presentation.Startup))]
namespace CrmEmna.Presentation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
