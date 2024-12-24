using Microsoft.AspNetCore.Mvc;

namespace Razor.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
