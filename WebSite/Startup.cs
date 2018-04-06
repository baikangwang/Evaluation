using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Evaluation.Startup))]
namespace Evaluation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
