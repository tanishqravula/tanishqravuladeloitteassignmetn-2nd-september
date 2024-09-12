using Microsoft.AspNetCore.Mvc;
using WebApplication6.Services;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsApiController : ControllerBase
    {
        public IProductService _service;
        public ProductsApiController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            Product obj = _service.GetProductById(id);
            if (obj == null)
            {
                return NotFound(new { result = "Requested product details are not available." });
            }
            return Ok(obj);
        }

        [HttpPost]
        public IActionResult Create(Product obj)
        {
            _service.AddProduct(obj);
            return Ok(new { result = "Product details added successfully." });
        }

        [HttpPut]
        public IActionResult Update(Product obj)
        {
            if (obj != null)
            {
                _service.UpdateProduct(obj);
                return Ok(new { result = "Product details updated successfully." });
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Product obj = _service.GetProductById(id);
            if (obj != null)
            {
                _service.DeleteProduct(id);
                return Ok(new { result = "Product details deleted successfully." });
            }
            return NotFound();
        }


        [HttpGet("category/{category}")]
        public IActionResult GetProductsByCategory(string category)
        {
            var products = _service.GetProductsByCategory(category);
            return Ok(products);
        }

        [HttpGet("outofstock")]
        public IActionResult GetOutOfStockProducts()
        {
            var products = _service.GetOutOfStockProducts();
            return Ok(products);
        }

        [HttpGet("pricerange")]
        public IActionResult GetProductsByPriceRange([FromQuery] decimal minPrice, [FromQuery] decimal maxPrice)
        {
            var products = _service.GetProductsByPriceRange(minPrice, maxPrice);
            return Ok(products);
        }

        [HttpGet("categories")]
        public IActionResult GetCategories()
        {
            var categories = _service.GetAllCategories();
            return Ok(categories);
        }
    }
}
