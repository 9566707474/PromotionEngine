namespace Abc.Promotion.Api.Service.Rules
{
    using Abc.Promotion.Api.Models;
    using System.Linq;

    /// <summary>
    /// Apply rule C and D for 30
    /// </summary>
    public class ThirdProductRule : IPromoRule
    {
        private const char productCodeC = 'C';

        private const char productCodeD = 'D';

        public Cart Execute(Cart cart)
        {
            var productC = cart.Products.FirstOrDefault(p => p.ProductCode == productCodeC);
            var productD = cart.Products.FirstOrDefault(p => p.ProductCode == productCodeD);

            if ((productC != null && productD != null) && productC.Quantity > 0 && productD.Quantity > 0)
            {
                if (productC.Quantity == productD.Quantity)
                {
                    productC.TotalPrice = 15 * productC.Quantity;
                }
                else if (productC.Quantity > productD.Quantity)
                {
                    productC.TotalPrice = (productC.Quantity - productD.Quantity) * productC.Price + productD.Quantity * 15;
                }
                else
                {
                    productC.TotalPrice = (productD.Quantity - productC.Quantity) * productC.Price + productD.Quantity * 15;
                }
            }

            return cart;
        }

        public bool IsMatch()
        {
            throw new System.NotImplementedException();
        }
    }
}
