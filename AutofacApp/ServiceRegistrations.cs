using System;
using System.Configuration;

using Autofac;
using System.IO;
using System.Linq;
using AutofacApp.Infrastructure;
using AutofacApp.Services;
using Module = Autofac.Module;
using System.Reflection;
using AutofacApp.Repository;

namespace AutofacApp
{
    public class ServiceRegistrations : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException("builder");
            }

            builder.Register<OrganizationNumberGenerator>().As<IOrganizationNumberGenerator>(); 
            builder.Register<OrganizationShortNameGenerator>().As<IOrganizationShortNameGenerator>();

            builder.Register<StudentRepository>();
            builder.Register<TeacherRepository>();
            builder.Register<IBaseRepository>();



        }

        //private static void RegisterMediatorServices(
        //    ContainerBuilder builder,
        //    Assembly[] assemblies)
        //{
        //    //builder.RegisterAssemblyTypes(assemblies)
        //    //    .Where(t =>
        //    //        t.IsClass &&
        //    //        !t.IsAbstract &
        //    //        typeof(OrganizationNumberGenerator) != t &&
        //    //        typeof(OrganizationShortNameGenerator) != t)
        //    //    .AsSelf()
        //    //    .AsImplementedInterfaces();

        //    builder.Register<OrganizationNumberGenerator>();
        //    builder.RegisterType<OrganizationShortNameGenerator>();


        //}

        
    }
}
