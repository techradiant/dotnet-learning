using ContosoCrafts.WebApp.Models;
using ContosoCrafts.WebApp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCrafts.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }
    }
}
