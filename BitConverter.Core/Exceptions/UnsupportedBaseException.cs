using System;

namespace BitConverter.Exceptions
{
    public class UnsupportedBaseException : Exception
    {
        public UnsupportedBaseException(string message) : base(message)
        {
        }
    }
}