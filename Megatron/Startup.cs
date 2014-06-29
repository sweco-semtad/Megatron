using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Megatron.Startup))]
namespace Megatron
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
