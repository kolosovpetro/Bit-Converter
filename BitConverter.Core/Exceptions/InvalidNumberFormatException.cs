using System;

namespace BitConverter.Exceptions
{
    public class InvalidNumberFormatException : Exception
    {
        public InvalidNumberFormatException(string message) : base(message)
        {
        }
    }
}