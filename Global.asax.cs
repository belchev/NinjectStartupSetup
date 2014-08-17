using Ninject.Web.Common;
using NinjectStartupSetup;
using NinjectStartupSetup.Utils;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace NinjectStartupSetup
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            NinjectDependencyResolver dependencyResolver = new NinjectDependencyResolver(new Bootstrapper().Kernel);

            GlobalConfiguration.Configuration.DependencyResolver = dependencyResolver;
            DependencyResolver.SetResolver(dependencyResolver);
        }
    }
}
