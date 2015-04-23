using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TicketingSystemTPOST.Startup))]
namespace TicketingSystemTPOST
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
