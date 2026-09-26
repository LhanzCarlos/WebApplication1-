using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Domain;
using WebApplication1.Models.DTO;
using WebApplication1.Repositories;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            var products = await _service.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProduct(int id)
        {
            var product = await _service.GetByIdAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<ProductDTO>> PostProduct(CreateProductDTO product)
        {
            return Ok(await _service.CreateAsync(product));
        }

        [HttpPut("{id}")]
        public Task<IActionResult> PutProduct(int id, ProductDTO product)
        {
            throw new NotImplementedException("PUT method is not implemented in the service layer. Implement it in the ProductService class.");
        }

        [HttpDelete("{id}")]
        public Task<IActionResult> DeleteProduct(int id)
        {
            throw new NotImplementedException("DELETE method is not implemented in the service layer. Implement it in the ProductService class.");
        }
    }
}