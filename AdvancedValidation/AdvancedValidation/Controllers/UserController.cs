using AdvancedValidation.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdvancedValidation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                if (userModel.Email == "test2@xom.xom")
                {
                    ModelState.AddModelError("Email", "این ایمیل تکراری است");
                    return View(userModel);
                }
                return Content("فرم به درستی دریافت شد");
            }
            ModelState.Clear();
            return View(userModel);
        }
    }
}
