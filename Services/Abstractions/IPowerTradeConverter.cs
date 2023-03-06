using System.Collections.Generic;

namespace Services.Abstractions
{
    public interface IPowerTradeConverter
    {
        IDictionary<int, double> ConvertToDictionary(IEnumerable<PowerTrade> powerTrades);
    }
}