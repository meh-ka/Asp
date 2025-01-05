using CustomScaffolding.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomScaffolding.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<UserModel> users = new List<UserModel>() {
            new UserModel{Id=1,Name="yek",Family="rast"},
            new UserModel{Id=2,Name="doo",Family="peich"},
            new UserModel{Id=3,Name="sei",Family="chen"},
            };
            return View(users);
        }

        public IActionResult Index2()
        {
            List<UserModel> users = new List<UserModel>() {
            new UserModel{Id=1,Name="yek",Family="rast"},
            new UserModel{Id=2,Name="doo",Family="peich"},
            new UserModel{Id=3,Name="sei",Family="chen"},
            };
            return View(users);
        }
    }
}
