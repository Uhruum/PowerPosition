using System.Collections.Generic;
using Services.Abstractions;

namespace Services.Implementations
{
    public class PowerTradeConverter : IPowerTradeConverter
    {
        public IDictionary<int, double> ConvertToDictionary(IEnumerable<PowerTrade> powerTrades)
        {
            Dictionary<int, double> trades = new Dictionary<int, double>();

            foreach (PowerTrade powerTrade in powerTrades)
            {
                foreach (var tradeItem in powerTrade.Periods)
                {
                    if (trades.ContainsKey(tradeItem.Period))
                        trades[tradeItem.Period] += tradeItem.Volume;
                    else
                        trades.Add(tradeItem.Period, tradeItem.Volume);
                }
            }

            return trades;
        }
    }
}