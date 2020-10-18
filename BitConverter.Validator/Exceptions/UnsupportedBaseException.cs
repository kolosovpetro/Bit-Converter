using System;

namespace BitConverter.Validator.Exceptions
{
    public class UnsupportedBaseException : Exception
    {
        public UnsupportedBaseException(string message) : base(message)
        {
        }
    }
}