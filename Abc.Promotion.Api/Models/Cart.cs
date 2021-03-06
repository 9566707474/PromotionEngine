namespace Abc.Promotion.Api.Models
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Cart class contains list of products, total amount and total discount applied
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Contructor to intialize the products
        /// </summary>
        public Cart() => Products = new List<Product>();

        /// <summary>
        /// Collection of products
        /// </summary>
        public ICollection<Product> Products { get; set; }

        /// <summary>
        /// Total discount applied
        /// </summary>
        public decimal TotalDiscount => Products.Sum(p => p.Discount);

        /// <summary>
        /// Total price
        /// </summary>
        public decimal TotalAmount => Products.Sum(p => p.TotalPrice);
    }
}
