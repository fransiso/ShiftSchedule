using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShiftSchedule.UI.MVC.Startup))]
namespace ShiftSchedule.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
