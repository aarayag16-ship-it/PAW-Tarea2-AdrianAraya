using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tarea_2.Startup))]
namespace Tarea_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
