namespace Abc.Promotion.Api.Service
{
    using Abc.Promotion.Api.Models;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class ApplyPromoRequestHandler : IRequestHandler<ApplyPromoRequest, Cart>
    {
        public Task<Cart> Handle(ApplyPromoRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
