using System.Collections.Generic;
using Domain.Models;

namespace Services.Abstractions
{
    public interface ICsvGenerator
    {
        void Generate(IEnumerable<TradeItem> items, string path);
    }
}