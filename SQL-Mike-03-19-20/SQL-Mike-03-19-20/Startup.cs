using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SQL_Mike_03_19_20.Startup))]
namespace SQL_Mike_03_19_20
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
