using HPlusSport.API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HPlusSport.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _Context;
        public ProductsController(ShopContext Context)
        {
            _Context = Context;
            _Context.Database.EnsureCreated();
        }
        [HttpGet]
        public IEnumerable<Products> GetAllProducts()
        {
            return _Context.Products.ToList();
            
        }
    }
}
