using System;
using System.Runtime.Serialization;

namespace Services.Exceptions
{
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
