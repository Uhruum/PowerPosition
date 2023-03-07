using System;
using System.Runtime.Serialization;
using Services.Abstractions;

namespace Services.Exceptions
{
    /// <summary>
    /// Thrown when general error occurres in <see cref="ICsvGenerator"/>
    /// </summary>
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