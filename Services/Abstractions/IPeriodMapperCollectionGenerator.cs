using System.Collections.Generic;

namespace Services.Abstractions
{
    public interface IPeriodMapperCollectionGenerator
    {
        IDictionary<int, string> GeneratePeriodMapperCollection();
    }
}
