using Microsoft.AspNetCore.Mvc;

namespace TransferData_TempData.Controllers
{
    public class TempDataController : Controller
    {
        public IActionResult Index()
        {
            TempData["Name"] = "yek";
            TempData.Keep();
            return View();
        }

        public IActionResult Index2()
        {
            var Name = TempData["Name"];
            ViewBag.MyName = Name ;
            return View();
        }
    }
}
