using Autofac;

namespace Presentation
{
    public static class ServiceCollection
    {
        public static void AddContainerBuilder(this ContainerBuilder containerBuilder)
        {

            containerBuilder.RegisterType<PowerPositionReportService>().AsSelf().InstancePerLifetimeScope();
        }
    }
}
