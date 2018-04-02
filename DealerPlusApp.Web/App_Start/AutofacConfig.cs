using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using DealerPlusApp.Data;
using DealerPlusApp.Data.Repositories;
using DealerPlusApp.Service.Service;
using System.Data.Entity;
using System.Web.Http;
using System.Web.Mvc;

namespace DealerPlusApp.Web.App_Start
{
    public class AutofacConfig
    {
        public static void RegisterContainer(HttpConfiguration configuration)
        {
          
            // Setup the Container Builder
            var builder = new ContainerBuilder();

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterType<DealerPlusEntities>()
                   .As<DbContext>()
                   .WithParameter("connectionstring", "Data Source=localhost;Initial Catalog=DealerPlusDB;Integrated Security=True");
            builder.RegisterControllers(typeof(DealerPlusApp.Web.WebApiApplication).Assembly);
          builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerLifetimeScope()
           .OnRelease(x => { ((IUnitOfWork)x).Commit(); });

            // OPTIONAL: Register model binders that require DI.
            //builder.RegisterModelBinders(typeof(DealerPlusApp.Data).Assembly);
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());
       
            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            // OPTIONAL: Enable action method parameter injection (RARE).
            //builder.InjectActionInvoker();
            builder.RegisterAssemblyTypes(typeof(EmployeeRepository).Assembly).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof(EmployeeService).Assembly).Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof(MarketRepository).Assembly).Where(t => t.Name.EndsWith("Repository")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(typeof(MarketService).Assembly).Where(t => t.Name.EndsWith("Service")).AsImplementedInterfaces();
            builder.RegisterType<EmployeeService>();
            builder.RegisterType<MarketService>();


            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            var resolver = new AutofacWebApiDependencyResolver(container);
            configuration.DependencyResolver = resolver;

        }
    }
}