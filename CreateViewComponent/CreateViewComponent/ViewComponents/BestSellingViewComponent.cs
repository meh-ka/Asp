using CreateViewComponent.Models.ViewComponentModels;
using Microsoft.AspNetCore.Mvc;

namespace CreateViewComponent.ViewComponents
{
    public class BestSellingViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string Title)
        {
            List<ProductModel> products = new List<ProductModel>() {
                new ProductModel{Id=1, Name="Math 1", Description="Description 1", Price=100},
                new ProductModel{Id=1, Name="Math 2", Description="Description 2", Price=100},
                new ProductModel{Id=1, Name="Math 3", Description="Description 3", Price=100},
                new ProductModel{Id=1, Name="Math 4", Description="Description 4", Price=100},
                };
                    ViewBag.Title=Title;
            return View("Index", products);
        }
    }
}
