using System;
using System.Runtime.Serialization;

namespace Services.Exceptions
{
    public class CsvGeneratorGeneralException : Exception
    {
        public CsvGeneratorGeneralException()
        {
        }

        public CsvGeneratorGeneralException(string message) : base(message)
        {
        }

        public CsvGeneratorGeneralException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CsvGeneratorGeneralException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}