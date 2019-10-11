using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttendanceLite.Data;
using AttendanceLite.Data.Repositories;
using Autofac;
using Autofac.Integration.Mvc;

namespace AttendanceLite.UI
{
    public static class DependencyConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterInstance(new ApplicationDbContext())
                .AsSelf().InstancePerRequest();

            builder.RegisterType(typeof(RepositoryBase<>))
                .As(typeof(IRepository<>)).InstancePerRequest();

            builder.RegisterType(typeof(TimeLogRepository))
                .As(typeof(ITimeLogRepository)).InstancePerRequest();

            builder.RegisterType(typeof(UnitOfWork))
                .As(typeof(IUnitOfWork)).InstancePerRequest();


            var container = builder.Build();
            DependencyResolver.SetResolver(container);
        }
    }
}