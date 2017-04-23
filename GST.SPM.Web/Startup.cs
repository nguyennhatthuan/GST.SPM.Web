using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GST.SPM.Web.Startup))]
namespace GST.SPM.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
