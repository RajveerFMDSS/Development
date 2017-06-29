using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace FMDSS.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<Interface.IRequestManager, Infrastructure.RequestManager>(new InjectionConstructor());
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}