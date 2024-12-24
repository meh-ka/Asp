using Microsoft.AspNetCore.Mvc;

namespace CustomTagHelper.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
