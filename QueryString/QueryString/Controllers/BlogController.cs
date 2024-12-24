using Microsoft.AspNetCore.Mvc;

namespace QueryString.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            string name = HttpContext.Request.Query["Name"].ToString();
            string family = HttpContext.Request.Query["Family"].ToString();
            ViewBag.Name = name +" "+family;
            return View();
        }

        public IActionResult index2(string name, string family) 
        {
            if (name==null || family == null)
            {
                ViewBag.Name = "il n'y a pas de valeur  ";
                return View();
                
            }
            ViewBag.Name = name +" "+family;
            return View();
        }

        public IActionResult index3(string id) 
        { 
            ViewBag.id= id;
            return View(); 
        }
    }
}
