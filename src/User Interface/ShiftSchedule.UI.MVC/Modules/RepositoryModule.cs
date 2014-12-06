using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using Autofac;

namespace ShiftSchedule.UI.MVC.Modules
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //will register every class that ends with “Repository” in Autofac.
            builder.RegisterAssemblyTypes(Assembly.Load("ShiftSchedule.DAL"))
                   .Where(t => t.Name.EndsWith("Repository"))
                   .AsImplementedInterfaces()
                  .InstancePerLifetimeScope();
        }
    }
}