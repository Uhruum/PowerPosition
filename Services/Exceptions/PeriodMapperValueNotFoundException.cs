using System;
using System.Runtime.Serialization;
using Services.Abstractions;

namespace Services.Exceptions
{
    /// <summary>
    /// Thrown when trying to resolve period in <see cref="IPeriodMapper"/>
    /// </summary>
    public class PeriodMapperValueNotFoundException : Exception
    {
        public PeriodMapperValueNotFoundException()
        {
        }

        public PeriodMapperValueNotFoundException(string message) : base(message)
        {
        }

        public PeriodMapperValueNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PeriodMapperValueNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
