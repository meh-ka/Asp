using Microsoft.AspNetCore.Mvc;

namespace ActionSelectors.Controllers
{
    
    public class BlogController : Controller
    {
        /*  [NonAction]*/
        [HttpGet]
        public string Index1()
        {
            return "index1";
        }
        [HttpPost]
        public string Index2()
        {
            return "index2";
        }
        [ActionName("Login")]
        [AcceptVerbs("Post", "Get", "Put")]
        public IActionResult Index3()
        {
            return View("Index3");
        }
    }
}
