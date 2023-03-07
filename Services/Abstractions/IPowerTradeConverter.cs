using System.Collections.Generic;

namespace Services.Abstractions
{
    /// <summary>
    /// Converts multiple day results returned from <see cref="IPowerService"/>
    /// into one as key value pair
    /// where key is period and value is summed volume for that period
    /// </summary>
    public interface IPowerTradeConverter
    {
        /// <summary>
        /// Converts multiple day results returned from <see cref="IPowerService"/>
        /// into one as key value pair
        /// where key is period and value is summed volume for that period
        /// </summary>
        /// <param name="powerTrades">day results returned from <see cref="IPowerService"/></param>
        /// <returns>key value pair of period and volume</returns>
        IDictionary<int, double> ConvertToDictionary(IEnumerable<PowerTrade> powerTrades);
    }
}