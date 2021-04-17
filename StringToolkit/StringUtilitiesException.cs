using System;
using System.Runtime.Serialization;

namespace StringToolkit
{
    [Serializable]
    public class StringUtilitiesException : Exception
    {
        public StringUtilitiesException()
        {
        }

        public StringUtilitiesException(string message) : base(message)
        {
        }

        public StringUtilitiesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected StringUtilitiesException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}