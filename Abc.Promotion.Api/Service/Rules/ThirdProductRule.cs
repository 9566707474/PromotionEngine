namespace Abc.Promotion.Api.Service.Rules
{
    using Abc.Promotion.Api.Models;

    /// <summary>
    /// Apply rule C and D for 30
    /// </summary>
    public class ThirdProductRule : IPromoRule
    {
        public Cart Execute(Cart cart)
        {
            throw new System.NotImplementedException();
        }

        public bool IsMatch()
        {
            throw new System.NotImplementedException();
        }
    }
}
