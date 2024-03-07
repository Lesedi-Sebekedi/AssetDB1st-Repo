using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AssetDB1st_test.Startup))]
namespace AssetDB1st_test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
