using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using Autofac;

namespace ShiftSchedule.UI.MVC.Modules
{
    public class ServiceModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //will register every class that ends with “Service” in Autofac.
            builder.RegisterAssemblyTypes(Assembly.Load("ShiftSchedule.Domain.Services"))
                      .Where(t => t.Name.EndsWith("Service"))
                      .AsImplementedInterfaces()
                      .InstancePerLifetimeScope();
        }
    }
}