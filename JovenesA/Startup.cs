using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JovenesA.Startup))]
namespace JovenesA
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
