namespace Abc.Promotion.Api.Service.Rules
{
    using Abc.Promotion.Api.Models;

    /// <summary>
    /// Apply rule 2 of B's for 45 
    /// </summary>
    public class SecondProductRule : IPromoRule
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
