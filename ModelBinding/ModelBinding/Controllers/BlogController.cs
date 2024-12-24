using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class BlogController : Controller
    {
            public IActionResult Index()
            {
                return View();

            }
            [HttpGet]
            public IActionResult Register()
            {
                return View();
            }
            /*[HttpPost]
            public IActionResult Register(string Name, string Family, string Age, string Gender )
            {
                return View();
            }*/

            [HttpPost]

            public IActionResult Register(RegisterUser registerUser)
            {
                    if (ModelState.IsValid)
                    {
                        return RedirectToAction("Index");

                    }
                    return View();
            }
    }
}
 