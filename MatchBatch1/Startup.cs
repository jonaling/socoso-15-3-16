using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MatchBatch1.Startup))]
namespace MatchBatch1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
