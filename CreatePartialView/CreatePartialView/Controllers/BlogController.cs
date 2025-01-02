using CreatePartialView.Models;
using Microsoft.AspNetCore.Mvc;

namespace CreatePartialView.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            List<Blog> blogs = new List<Blog>() {
            new Blog{Id=1, Url= "../img/slider/1.jpg", Title="Titre 1",Description="Description 1 ...." },
            new Blog{Id=2, Url= "../img/slider/2.jpg", Title="Titre 2",Description="Description 2 ...." },
            new Blog{Id=3, Url= "../img/slider/3.jpg", Title="Titre 3",Description="Description 3 ...." },
            new Blog{Id=4, Url= "../img/slider/4.jpg", Title="Titre 4",Description="Description 4 ...." },
            new Blog{Id=5, Url= "../img/slider/5.jpg", Title="Titre 5",Description="Description 5 ...." },
            new Blog{Id=6, Url= "../img/slider/6.jpg", Title="Titre 6",Description="Description 6 ...." },
            new Blog{Id=7, Url= "../img/slider/7.jpg", Title="Titre 7",Description="Description 7 ...." },
            new Blog{Id=8, Url= "../img/slider/8.png", Title="Titre 8",Description="Description 8 ...." },

            };
            return View(blogs);
        }
    }
}
