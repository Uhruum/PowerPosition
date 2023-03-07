using System.Collections.Generic;

namespace Services.Abstractions
{
    /// <summary>
    /// Generates key value pair of <see cref="int"/> and <see cref="string"/>
    /// </summary>
    public interface IPeriodMapperCollectionGenerator
    {
        /// <summary>
        /// Generates key value pair of <see cref="int"/> and <see cref="string"/>
        /// where key is period and value ih hourly representation of that period
        /// </summary>
        /// <returns>key value pair of <see cref="int"/> and <see cref="string"/></returns>
        IDictionary<int, string> GeneratePeriodMapperCollection();
    }
}
