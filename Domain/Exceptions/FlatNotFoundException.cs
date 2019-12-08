using System;

namespace Domain.Exceptions
{
    public class FlatNotFoundException : Exception
    {
        public FlatNotFoundException()
        {
        }

        public FlatNotFoundException(string message) : base(message)
        {
        }
        public FlatNotFoundException(string message, Exception ex) : base(message, ex)
        {
        }
    }
}
