using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureExample.Application.Features.Commands.CreateProduct;
using OnionArchitectureExample.Application.Features.Queries.GetAllProducts;
using OnionArchitectureExample.Application.Features.Queries.GetProductById;

namespace OnionArchitectureExample.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllProductsQuery();

            return Ok(await mediator.Send(query));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetProductByIdQuery() { Id = id };

            return Ok(await mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommand command)
        {
            return Ok(await mediator.Send(command));
        }


    }
}
