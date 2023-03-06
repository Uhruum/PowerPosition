using Autofac;
using System.ServiceProcess;

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();
            ServiceCollection.AddContainerBuilder(containerBuilder);
            IContainer container = containerBuilder.Build();
            ServiceBase.Run(container.Resolve<PowerPositionReportService>());
        }
    }
}
