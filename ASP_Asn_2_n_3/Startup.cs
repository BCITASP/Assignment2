using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASP_Asn_2_n_3.Startup))]
namespace ASP_Asn_2_n_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
