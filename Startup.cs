using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieRender.Startup))]
namespace MovieRender
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
