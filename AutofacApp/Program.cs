using Autofac;
using Autofac.Core;
using AutofacApp.Infrastructure;
using AutofacApp.Repository;
using AutofacApp.Services;
using System;
using System.Linq;

namespace AutofacApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = CreateContainer();

            var orgName = container.Resolve<OrganizationShortNameGenerator>();
            var b = orgName.Generate("muna");
            Console.WriteLine(b);


            var stuRepo = container.Resolve<StudentRepository>();
            var id = stuRepo.GetId();




        }

        private static IContainer CreateContainer()
        {
            var assemblies = AssembliesProvider
                 .Instance
                 .Assemblies
                 .ToArray();

            var builder = new ContainerBuilder();

            builder.RegisterAssemblyModules(assemblies);

            IContainer container = null;
            builder.RegisterInstance<Func<IContainer>>(() => container)
                .AsSelf()
                .AsImplementedInterfaces();

            container = builder.Build();
            Console.WriteLine("Build Container Completed.");

            return container;
        }
    }
}
