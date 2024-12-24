using Microsoft.AspNetCore.Mvc;
using TransferData_ViewBag_ViewData.Models;

namespace TransferData_ViewBag_ViewData.Controllers
{
    public class ViewDataController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "it.xom";
            Users users = new Users();
            users.UserId = 100;
            users.UserName = "doo";
            users.UserFamily = "pech";

            ViewData["MyUser"] = users;
            return View();
        }
    }
}
