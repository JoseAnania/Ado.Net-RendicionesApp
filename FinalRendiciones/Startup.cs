using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalRendiciones.Startup))]
namespace FinalRendiciones
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
