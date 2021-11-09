namespace Abc.Promotion.Api.Service
{
    using Abc.Promotion.Api.Exceptions;
    using Abc.Promotion.Api.Models;
    using Abc.Promotion.Api.Service.Rules;
    using System.Collections.Generic;

    /// <summary>
    /// Apply promo rule engin
    /// </summary>
    public class ApplyPromo : IApplyPromo
    {
        private readonly List<IPromoRule> _rules = new List<IPromoRule>();

        public Cart Execute(Cart cart)
        {
            if (cart?.Products == null || cart.Products.Count == 0)
            {
                throw new CartIsEmptyException("Cart is empty.Promo rules not applied");
            }

            foreach (var rule in _rules)
            {
                cart = rule.Execute(cart);
            }

            return cart;
        }
    }
}
