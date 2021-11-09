namespace Abc.Promotion.Api.Service.Rules
{
    using Abc.Promotion.Api.Models;
    using System.Linq;

    /// <summary>
    /// Apply rule 2 of B's for 45 
    /// </summary>
    public class SecondProductRule : IPromoRule
    {
        private const char productCode = 'B';

        public Cart Execute(Cart cart)
        {
            var productB = cart.Products.FirstOrDefault(p => p.ProductCode == productCode);
            if (productB != null)
            {
                productB.TotalPrice = (productB.Quantity / 2) * 45 + (productB.Quantity % 2) * productB.Price;
            }

            return cart;
        }

        public bool IsMatch()
        {
            throw new System.NotImplementedException();
        }
    }
}
