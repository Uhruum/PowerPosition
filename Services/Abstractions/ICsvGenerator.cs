using System.Collections.Generic;
using Domain.Models;

namespace Services.Abstractions
{
    public interface ICsvGenerator
    {
        bool Generate(IEnumerable<TradeItem> items, string path);
    }
}