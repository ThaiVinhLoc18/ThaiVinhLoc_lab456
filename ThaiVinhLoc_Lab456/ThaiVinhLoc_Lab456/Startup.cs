using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThaiVinhLoc_Lab456.Startup))]
namespace ThaiVinhLoc_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
