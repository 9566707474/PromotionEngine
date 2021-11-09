namespace Abc.Promotion.Api.Service.Rules
{
    using Abc.Promotion.Api.Models;

    public interface IPromoRule
    {
        bool IsMatch();

        Cart Execute(Cart cart);
    }
}
