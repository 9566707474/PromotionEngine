namespace Abc.Promotion.Api.Test.Controllers
{
    using Abc.Promotion.Api.Models;
    using Abc.Promotion.Api.Test.InfraSetup;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Formatting;
    using System.Threading.Tasks;
    using Xunit;

    [Collection("Price Promo")]
    public class PromotionControllerTest : IClassFixture<PromotionWebApplicationFactory<Abc.Promotion.Api.Startup>>
    {
        private readonly HttpClient _client;

        public PromotionControllerTest(PromotionWebApplicationFactory<Abc.Promotion.Api.Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ApplyPricePromotionShouldSuccessScenario1()
        {
            var cart = new Cart()
            {
                Products = new List<Product>()
                {
                    new Product { ProductCode = 'A',Price = 50, Quantity= 1,TotalPrice = 50 },
                    new Product { ProductCode = 'B',Price = 30, Quantity= 1,TotalPrice = 30 },
                    new Product { ProductCode = 'C',Price = 20, Quantity= 1,TotalPrice = 20 }
                }
            };

            var formatter = new JsonMediaTypeFormatter();

            // The endpoint or route of the controller action.
            var httpResponse = await _client.PostAsync<Cart>("/api/promotion", cart, formatter);

            // Deserialize and examine results.
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<Cart>(stringResponse);
            Assert.IsAssignableFrom<Cart>(response);
            Assert.Equal(100, response.TotalAmount);
            Assert.Equal(0, response.TotalDiscount);
        }

        [Fact]
        public async Task ApplyPricePromotionShouldSuccessScenario2()
        {
            var cart = new Cart()
            {
                Products = new List<Product>()
                {
                    new Product { ProductCode = 'A',Price = 50, Quantity= 4, TotalPrice = 200 },
                    new Product { ProductCode = 'B',Price = 30, Quantity= 5, TotalPrice= 150 },
                    new Product { ProductCode = 'C',Price = 20, Quantity= 1,TotalPrice = 20 },
                }
            };

            var formatter = new JsonMediaTypeFormatter();

            // The endpoint or route of the controller action.
            var httpResponse = await _client.PostAsync<Cart>("/api/promotion", cart, formatter);

            // Deserialize and examine results.
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<Cart>(stringResponse);
            Assert.IsAssignableFrom<Cart>(response);
            Assert.Equal(320, response.TotalAmount);
            Assert.Equal(50, response.TotalDiscount);
        }

        [Fact]
        public async Task ApplyPricePromotionShouldSuccessScenario3()
        {
            var cart = new Cart()
            {
                Products = new List<Product>()
                {
                    new Product { ProductCode = 'A',Price = 50, Quantity= 3, TotalPrice = 150 },
                    new Product { ProductCode = 'B',Price = 30, Quantity= 5, TotalPrice= 150 },
                    new Product { ProductCode = 'C',Price = 20, Quantity= 1,TotalPrice = 20 },
                    new Product { ProductCode = 'D',Price = 15, Quantity= 1,TotalPrice = 15 }
                }
            };

            var formatter = new JsonMediaTypeFormatter();

            // The endpoint or route of the controller action.
            var httpResponse = await _client.PostAsync<Cart>("/api/promotion", cart, formatter);

            // Deserialize and examine results.
            var stringResponse = await httpResponse.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<Cart>(stringResponse);
            Assert.IsAssignableFrom<Cart>(response);
            Assert.Equal(280, response.TotalAmount);
            Assert.Equal(55, response.TotalDiscount);
        }
    }
}
