using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodSever.Startup))]
namespace FoodSever
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
