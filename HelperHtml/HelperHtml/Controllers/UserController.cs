using HelperHtml.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelperHtml.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            Person person = new Person 
            {
                Id = 1,
                Name = ": yek ",
                Family= ": rast ",
                Description = ": Description",
                Gender = true,
            };
            return View(person);
        }
    }
}
