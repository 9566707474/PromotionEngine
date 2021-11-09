namespace Abc.Promotion.Api.Service
{
    using Abc.Promotion.Api.Models;

    public interface IApplyPromo
    {
        Cart Execute(Cart cart);
    }
}
