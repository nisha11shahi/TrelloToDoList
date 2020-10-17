using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrelloToDoList.Startup))]
namespace TrelloToDoList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
