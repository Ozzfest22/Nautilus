using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pruebas3_.Startup))]
namespace Pruebas3_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
