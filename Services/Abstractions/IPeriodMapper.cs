using Services.Exceptions;

namespace Services.Abstractions
{
    /// <summary>
    /// Returns <see cref="string"/> representation as time of day for specific period
    /// represented as <see cref="int"/>
    /// </summary>
    public interface IPeriodMapper
    {
        /// <summary>
        /// Returns <see cref="string"/> representation as time of day for specific period
        /// represented as <see cref="int"/>
        /// </summary>
        /// <param name="period"><see cref="int"/> representation of time of day like 1-24</param>
        /// <returns><see cref="string"/> representation of time of day like 23:00 h on day before to 22:00 </returns>
        /// <exception cref="PeriodMapperValueNotFoundException"></exception>
        string MapPeriod(int period);
    }
}
