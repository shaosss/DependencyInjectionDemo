using System;
using Autofac;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //StartSimple();
            //StartWindsor();
            StartAutoFac();
            Console.ReadKey();
        }

        static void StartSimple()
        {
            var someBl = new BusinessLogic(new GoodDataBase());
            someBl.DoSomeActions();
        }

        static void StartWindsor()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<BusinessLogic>());
            container.Register(Component.For<IDataBase>().ImplementedBy<BetterDataBase>()
                .LifestyleSingleton());
            var bl = container.Resolve<BusinessLogic>();
            bl.DoSomeActions();
        }

        static void StartAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<BusinessLogic>().AsSelf();
            builder.RegisterType<BetterDataBase>().As<IDataBase>().SingleInstance();
            var container = builder.Build();
            var bl = container.Resolve<BusinessLogic>();
            bl.DoSomeActions();
        }
    }
}