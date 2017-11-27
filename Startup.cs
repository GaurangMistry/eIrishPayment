using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eIrishPayment.Startup))]
namespace eIrishPayment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
