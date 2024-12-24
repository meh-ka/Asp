    using Microsoft.AspNetCore.Mvc;
    using ModelLayer.Models;

    namespace ModelLayer.Controllers
    {
        public class ProductController : Controller
        {
        public IActionResult ShowProduct()
            {
                Product Myproduct=new Product();
                Myproduct.ProductId = 1;
                Myproduct.ProductName = "iphon 12 mini";
                Myproduct.ProductDescription = "meilleur portable 2024 ";
                Myproduct.ProductPrice = 1000;
                return View(Myproduct);
            }
            public IActionResult ListProduct()
            {
                Product products = new Product();
                List<Product> ProductList = new List<Product>()
                {
                        new Product(){ProductId=1, ProductName="iphon 11 mini", ProductDescription="meilleur portable 2024", ProductPrice=1000},
                        new Product(){ProductId=2, ProductName="iphon 12 mini", ProductDescription="meilleur portable 2024", ProductPrice=1000},
                        new Product(){ProductId=3, ProductName="iphon 13 mini", ProductDescription="meilleur portable 2024", ProductPrice=1000},
                        new Product(){ProductId=4, ProductName="iphon 14 mini", ProductDescription="meilleur portable 2024", ProductPrice=1000},
                        new Product(){ProductId=5, ProductName="iphon 15 mini", ProductDescription="meilleur portable 2024", ProductPrice=1000},
                        new Product(){ProductId=6, ProductName="iphon 16 mini", ProductDescription="meilleur portable 2024", ProductPrice=1000},
                        new Product(){ProductId=7, ProductName="iphon 12 pro", ProductDescription="meilleur portable 2024", ProductPrice=1000},
                        new Product(){ProductId=8, ProductName="iphon 13 pro", ProductDescription="meilleur portable 2024", ProductPrice=1000},
                        new Product(){ProductId=9, ProductName="iphon 14 pro", ProductDescription="meilleur portable 2024", ProductPrice=1000},
                        new Product(){ProductId=10, ProductName="iphon 15 pro", ProductDescription="meilleur portable 2024", ProductPrice=1000},
                };
                return View(ProductList);
            }    
        }
    }
