using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsLearning.WebApp.Startup))]
namespace WebFormsLearning.WebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
