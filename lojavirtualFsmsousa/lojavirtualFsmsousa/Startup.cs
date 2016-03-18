using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lojavirtualFsmsousa.Startup))]
namespace lojavirtualFsmsousa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
