using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LojaDeGames.Startup))]
namespace LojaDeGames
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
