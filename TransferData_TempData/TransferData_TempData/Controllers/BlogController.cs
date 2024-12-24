using Microsoft.AspNetCore.Mvc;

namespace TransferData_TempData.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var Name = TempData["Name"];
            return View();
        }
    }

}
