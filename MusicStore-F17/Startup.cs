using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MusicStore_F17.Startup))]
namespace MusicStore_F17
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
