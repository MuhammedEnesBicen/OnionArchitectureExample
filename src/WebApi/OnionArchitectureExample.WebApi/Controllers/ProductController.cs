using Microsoft.AspNetCore.Mvc;
using OnionArchitectureExample.Application.Interfaces.Repository;

namespace OnionArchitectureExample.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var allList = await productRepository.GetAllAsync();
            return Ok(allList);
        }

    }
}
