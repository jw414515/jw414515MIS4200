using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jw414515MIS4200.Startup))]
namespace jw414515MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
