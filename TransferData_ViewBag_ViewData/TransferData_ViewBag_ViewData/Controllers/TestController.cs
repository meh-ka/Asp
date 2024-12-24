using Microsoft.AspNetCore.Mvc;

namespace TransferData_ViewBag_ViewData.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "ViewData Name";
            ViewBag.Name = "ViewBag Name";
            
            return View();
        }
    }
}
