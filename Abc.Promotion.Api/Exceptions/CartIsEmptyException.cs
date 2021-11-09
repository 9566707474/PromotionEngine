namespace Abc.Promotion.Api.Exceptions
{
    using System;

    public class CartIsEmptyException : ApplicationException
    {
        public CartIsEmptyException() { }
        public CartIsEmptyException(string message) : base(message) { }
    }
}
