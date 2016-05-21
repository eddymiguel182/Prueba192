using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eddy_Prueba.Startup))]
namespace Eddy_Prueba
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
