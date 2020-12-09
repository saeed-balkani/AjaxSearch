using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxSearch.Startup))]
namespace AjaxSearch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
