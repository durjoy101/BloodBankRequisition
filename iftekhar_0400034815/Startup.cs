using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(iftekhar_0400034815.Startup))]
namespace iftekhar_0400034815
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
