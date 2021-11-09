namespace Abc.Promotion.Api.Controllers
{
    using Abc.Promotion.Api.Models;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    [ApiController]
    public class PromotionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PromotionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<Cart>> Post([FromBody] Cart cart)
        {
            try
            {
                throw new System.NotImplementedException();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
