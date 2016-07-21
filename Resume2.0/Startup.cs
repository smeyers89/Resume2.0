using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Resume2._0.Startup))]
namespace Resume2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
