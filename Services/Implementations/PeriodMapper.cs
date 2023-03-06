using Services.Abstractions;
using Services.Exceptions;
using System.Collections.Generic;

namespace Services.Implementations
{
    public class PeriodMapper : IPeriodMapper
    {
        private readonly IDictionary<int,string> _periods;

        public PeriodMapper(IPeriodMapperCollectionGenerator generator)
        {
            _periods = generator.GeneratePeriodMapperCollection();
        }

        public string MapPeriod(int period)
        {
            return _periods.TryGetValue(period, out string value)
                ? value
                : throw new PeriodMapperValueNotFoundException($"Could not found value for provided period : {period}");
        }
    }
}
