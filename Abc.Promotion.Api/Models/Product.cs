namespace Abc.Promotion.Api.Models
{
    /// <summary>
    /// Product class
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Product code
        /// </summary>
        public char ProductCode { get; set; }

        /// <summary>
        /// Product price
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Product quantity 
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Product total amount
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// Applied discount for the product
        /// </summary>
        public decimal Discount => (Quantity * Price) - TotalPrice;
    }
}
