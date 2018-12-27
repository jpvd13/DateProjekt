using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DateProjekt.Startup))]
namespace DateProjekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
