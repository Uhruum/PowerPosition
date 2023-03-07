using System.Collections.Generic;
using Domain.Models;

namespace Services.Abstractions
{
    /// <summary>
    /// Generates csv file
    /// </summary>
    public interface ICsvGenerator
    {
        /// <summary>
        /// Generates csv file from list of <see cref="TradeItem"/>
        /// on specific path
        /// </summary>
        /// <param name="items">list of <see cref="TradeItem"/></param>
        /// <param name="path">path to directory where csv is generated</param>
        void Generate(IEnumerable<TradeItem> items, string path);
    }
}