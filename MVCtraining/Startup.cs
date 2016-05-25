using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCtraining.Startup))]
namespace MVCtraining
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
