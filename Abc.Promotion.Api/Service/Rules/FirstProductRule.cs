namespace Abc.Promotion.Api.Service.Rules
{
    using System.Linq;

    using Abc.Promotion.Api.Models;

    /// <summary>
    /// Apply promo if 3 of A's for 130
    /// </summary>
    public class FirstProductRule : IPromoRule
    {
        private const char productCode = 'A';

        public Cart Execute(Cart cart)
        {
            var productA = cart.Products.FirstOrDefault(p => p.ProductCode == productCode);
            if (productA != null)
            {
                productA.TotalPrice = (productA.Quantity / 3) * 130 + (productA.Quantity % 3) * productA.Price;
            }

            return cart;
        }

        /// <summary>
        /// implemnt this method to apply filter conditions
        /// </summary>
        /// <returns></returns>
        public bool IsMatch()
        {
            throw new System.NotImplementedException();
        }
    }
}
