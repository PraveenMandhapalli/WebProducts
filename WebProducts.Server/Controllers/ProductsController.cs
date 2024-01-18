using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebProducts.Server.Data;

namespace WebProducts.Server.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;

        private readonly Context _context;
        public ProductsController(ILogger<ProductsController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var rec = _context.Products.ToList();
            return Ok(rec);
        }
        [HttpGet]
        public IActionResult GetCountryCode()
        {
            var rec = _context.Countries.Select(x=>x.CountryCode).ToList(); 
            return Ok(rec);
        }
    }
}

