namespace Abc.Promotion.Api.Test.Service
{
    using Abc.Promotion.Api.Models;
    using Abc.Promotion.Api.Service;
    using Moq;
    using Xunit;

    public class ApplyPromoRequestHandlerTest
    {
        private readonly ApplyPromoRequestHandler underTest;
        private Mock<IApplyPromo> applyPromo;

        public ApplyPromoRequestHandlerTest()
        {
            applyPromo = new Mock<IApplyPromo>();
            underTest = new ApplyPromoRequestHandler(applyPromo.Object);
        }

        [Fact]
        public async void PromoRequestHandlerShouldSuccess()
        {
            var request = new Cart();

            applyPromo.Setup(m => m.Execute(request)).Returns(request);
            var applyPromoRequest = new ApplyPromoRequest() { Cart = request };
            var result = await underTest.Handle(applyPromoRequest, default);
            Assert.NotNull(result);
        }
    }
}
