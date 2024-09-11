using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Services;
using WebApplication6.Models;
using WebApplication6.Repositories;
using System.Diagnostics.Eventing.Reader;

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
            else
            {
                return Ok(obj);
            }
        }
        [HttpPost]
        public IActionResult Create(Product obj)
        {
            _service.AddProduct(obj);
            return Ok(new { result = "Product details added succesfully" });
        }
        [HttpPut]
        public IActionResult Update(Product obj)
        {
            if (obj != null)
            {
                _service.UpdateProduct(obj);
                return Ok(new { result = "Product details updated succesfully" });
            }
            else
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Product obj = _service.GetProductById(id);
            if (obj != null)
            {
                _service.DeleteProduct(id);
                return Ok(new { result = "Product details deleted succesfully" });
            }
            else
            {
                return NotFound();
            }
        }

    }
}
