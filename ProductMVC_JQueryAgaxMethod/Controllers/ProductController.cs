using Microsoft.AspNetCore.Mvc;
using ProductMVC_JQueryAgaxMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductMVC_JQueryAgaxMethod.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ContentResult Demo1()
        {
            return Content("Hello", "text/plain");
        }

        [HttpPost]
        public ContentResult Demo2(string fullName)
        {
            return Content("Hello " + fullName, "text/plain");
        }
        public IActionResult Demo3()
        {
            var product = new ProductModel()
            {
                Id = "s01",
                Name = "Diclofenic",
                Price = 550
            };
            return new JsonResult(product);
        }
        public IActionResult Demo4()
        {
            var products = new List<ProductModel>()
            {
                new ProductModel()
                {
                    Id="R01",
                    Name="Dexorange",
                    Price=121
                },
                new ProductModel()
                {
                    Id="g01",
                    Name="Amoxycilin",
                    Price=116
                },
                new ProductModel()
                {
                    Id="M03",
                    Name="Ciprobid",
                    Price=500
                }
            };
            return new JsonResult(products);
        }
    }
}
