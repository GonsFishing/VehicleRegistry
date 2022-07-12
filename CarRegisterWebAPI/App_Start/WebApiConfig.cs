using CarRegister.Repo.interfaces;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using CarRegister.Repo.DataAccess;
using CarRegister.Domain.Interfaces;
using VehicleRegister.Domain.Service;
using VehicleRegister.Domain.Service.interfaces;
using CarRegister.Repo.Interfaces;

namespace CarRegisterWebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

		public static void SimpleInjection(HttpConfiguration config)
		{
            var Container = new Container();
            Container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();

			Container.Register<IRepository, LocalSQLStorage>(Lifestyle.Scoped);
            Container.Register<IVehicleServiceRepository, LocalSQLStorage>(Lifestyle.Scoped);

            Container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            Container.Verify();
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(Container);       
        }
    }
}
