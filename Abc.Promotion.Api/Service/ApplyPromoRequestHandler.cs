namespace Abc.Promotion.Api.Service
{
    using Abc.Promotion.Api.Models;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    public class ApplyPromoRequestHandler : IRequestHandler<ApplyPromoRequest, Cart>
    {
        private readonly IApplyPromo _applyPromo;
        public ApplyPromoRequestHandler(IApplyPromo applyPromo)
        {
            _applyPromo = applyPromo;
        }

        public Task<Cart> Handle(ApplyPromoRequest request, CancellationToken cancellationToken)
        {
            var cart = _applyPromo.Execute(request.Cart);
            return Task.FromResult(cart);
        }
    }
}
