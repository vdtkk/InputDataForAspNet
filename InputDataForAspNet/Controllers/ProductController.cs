using InputDataForAspNet.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputDataForAspNet.Controllers
{
    public class ProductController : Controller
    {

        List<Product> products = new List<Product>()
            {
                new Product(){Id=1,ProductName="Televizyon",CategoryName="Elektronik" },
                new Product(){Id=2,ProductName="Monitor",CategoryName="Elektronik"},
                new Product(){Id=3,ProductName="Buzdolabı",CategoryName="Beyaz Eşya"},
                new Product(){Id=4,ProductName="Çamaşır Makinesi",CategoryName="Beyaz Eşya"}
            };

        public IActionResult GetallProducts()
        {
            return View(products);
        }


        public IActionResult GetProductId(int id)
        {
            Product product = products.Find(x => x.Id == id);
            if(product is null )
            {
                ViewBag.Error = "Verilen Id ile ürün bulunamadı";
            }
            return View(product);
        }

        //home/index?name=ugur&surname=sesen
        public string QueryString(string name,string surname)
        {
            return "uygulama başarılı şekilde çalıştı";
        }

        public IActionResult GetProductsByCategoryName(string categoryName)
        {
            List<Product> product = products.FindAll(x => x.CategoryName == categoryName);
            if (product.Count == 0)
            {
                ViewData["Error"] = "Verilen Id ile ürün bulunamadı";
            }
            return View(product);
        }
    }
}
