
using Autofac;
using Services;
using Services.Abstractions;
using Services.Implementations;

namespace Presentation
{
    public static class ServiceCollection
    {
        public static void AddContainerBuilder(this ContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterType<PowerPositionReportService>().AsSelf().InstancePerLifetimeScope();
            containerBuilder.RegisterType<PeriodMapperCollectionGenerator>().As<IPeriodMapperCollectionGenerator>()
                .InstancePerLifetimeScope();
            containerBuilder.RegisterType<PeriodMapper>().As<IPeriodMapper>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<PowerTradeConverter>().As<IPowerTradeConverter>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<TradeItemConverter>().As<ITradeItemConverter>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<PowerService>().As<IPowerService>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<CsvGenerator>().As<ICsvGenerator>().InstancePerLifetimeScope();
            containerBuilder.RegisterType<ReportService>().As<IReportService>().InstancePerLifetimeScope();
        }
    }
}
