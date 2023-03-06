using Services.Abstractions;
using System;
using System.Collections.Generic;

namespace Services.Implementations
{
    public class PeriodMapperCollectionGenerator : IPeriodMapperCollectionGenerator
    {
        private static readonly string HourPattern = "HH:mm";
        public IDictionary<int, string> GeneratePeriodMapperCollection()
        {
            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 0, 0);
            Dictionary<int, string> result = new Dictionary<int, string>();
            for (int i = 1; i <= 24; i++) {
                result.Add(i, date.ToString(HourPattern));
                date = date.AddHours(1);
            }
            return result;
        }
    }
}
