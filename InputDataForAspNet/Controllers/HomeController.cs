using InputDataForAspNet.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputDataForAspNet.Controllers
{
    public class HomeController : Controller
    {
        //public string Index(string id, string name)
        //{
        //    return   "uygulama çalışıyor";
        //} 

        public string Index(Product product)
        {
            return    "uygulama çalışıyor";
        }
    }
}
