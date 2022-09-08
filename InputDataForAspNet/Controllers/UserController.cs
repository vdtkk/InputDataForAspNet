using InputDataForAspNet.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputDataForAspNet.Controllers
{
    public class UserController : Controller
    {



        public IActionResult AddUser()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddUser(string userName,string surName)
        //{
        //    return View();
        //}

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            return View();
        }
    }
}
