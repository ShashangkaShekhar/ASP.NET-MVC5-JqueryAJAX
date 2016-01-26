using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JqueryAJAX.Startup))]
namespace JqueryAJAX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
