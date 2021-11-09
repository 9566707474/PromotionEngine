namespace Abc.Promotion.Api.Service
{
    using Abc.Promotion.Api.Models;
    using MediatR;

    public sealed class ApplyPromoRequest : IRequest<Cart>
    {
        public Cart Cart { get; set; }
    }
}
