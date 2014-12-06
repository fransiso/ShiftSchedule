using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Reflection;
using Autofac;
using ShiftSchedule.DAL;
using ShiftSchedule.DAL.ORM.EF.Context;
using ShiftSchedule.Domain.Services.Base;


namespace ShiftSchedule.UI.MVC.Modules
{
    public class EFModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule(new RepositoryModule());

            builder.RegisterType(typeof(EFContext)).As(typeof(DbContext)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(EfUnitOfWork)).As(typeof(IUnitOfWork)).InstancePerRequest();

        }

    }
}