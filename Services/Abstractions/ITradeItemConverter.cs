using Domain.Models;
using System.Collections.Generic;

namespace Services.Abstractions
{
    public interface ITradeItemConverter
    {
        IEnumerable<TradeItem> Convert(IDictionary<int, double> powerTradeDictionary);
    }
}