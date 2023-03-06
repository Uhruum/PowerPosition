using System.Collections.Generic;
using System.Linq;
using Domain.Models;
using Services.Abstractions;

namespace Services.Implementations
{
    public class TradeItemConverter : ITradeItemConverter
    {
        private readonly IPeriodMapper _periodMapper;

        public TradeItemConverter(IPeriodMapper periodMapper)
        {
            _periodMapper = periodMapper;
        }

        public IEnumerable<TradeItem> Convert(IDictionary<int, double> powerTradeDictionary)
        {
            return powerTradeDictionary.Select(item =>
                new TradeItem()
                {
                    LocalTime = _periodMapper.MapPeriod(item.Key),
                    Volume = item.Value
                }
            );
        }
    }
}