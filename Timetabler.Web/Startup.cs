using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Timetabler.Web.Startup))]
namespace Timetabler.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
