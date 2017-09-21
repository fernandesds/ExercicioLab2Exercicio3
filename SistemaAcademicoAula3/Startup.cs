using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SistemaAcademicoAula3.Startup))]
namespace SistemaAcademicoAula3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
