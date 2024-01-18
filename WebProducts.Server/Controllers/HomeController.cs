using Microsoft.AspNetCore.Mvc;

namespace WebProducts.Server.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Home controller");
        }
    }
}
