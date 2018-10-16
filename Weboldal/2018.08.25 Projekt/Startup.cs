using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2018._08._25_Projekt.Startup))]
namespace _2018._08._25_Projekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
