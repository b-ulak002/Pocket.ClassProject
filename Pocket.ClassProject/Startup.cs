using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pocket.ClassProject.Startup))]
namespace Pocket.ClassProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
