using System;

namespace BitConverter.Exceptions
{
    public class NullNumberException : Exception
    {
        public NullNumberException(string message) : base(message)
        {
        }
    }
}