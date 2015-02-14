using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(w06a.Startup))]
namespace w06a
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
