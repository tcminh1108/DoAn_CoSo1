using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoAn_CoSo1.Startup))]
namespace DoAn_CoSo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
