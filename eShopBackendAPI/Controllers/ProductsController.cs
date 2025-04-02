using eShopBackendAPI.Data;
using eShopBackendAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eShopBackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(StoreContext _context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return await _context.Products.ToListAsync();  
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var products = await _context.Products.FindAsync(id);
            if (products == null) return NotFound();
            return Ok(products);
        }
    }
}
