using Domain.Models;
using System.Collections.Generic;

namespace Services.Abstractions
{
    /// <summary>
    /// Converts key value pair of period and volume to <see cref="TradeItem"/>
    /// </summary>
    public interface ITradeItemConverter
    {
        /// <summary>
        /// Converts key value pair of period and volume to <see cref="TradeItem"/>.
        /// Also converts period to string representation of it and rounds up volume to closer whole
        /// number.
        /// </summary>
        /// <param name="powerTradeDictionary">key value pair of period and volume</param>
        /// <returns>list of <see cref="TradeItem"/></returns>
        IEnumerable<TradeItem> Convert(IDictionary<int, double> powerTradeDictionary);
    }
}