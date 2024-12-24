using Microsoft.AspNetCore.Mvc;
using TransferData_ViewBag_ViewData.Models;

namespace TransferData_ViewBag_ViewData.Controllers
{
    public class ViewBagController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "It.xom";
            ViewBag.Time= DateTime.Now;

            ViewBag.User = new Users
            {
                 UserId = 1,
                 UserName = "yek",
                 UserFamily = "rasta"

            };
            return View();
        }
    }
}
