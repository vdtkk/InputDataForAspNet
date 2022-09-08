using InputDataForAspNet.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputDataForAspNet.Controllers
{

       public class ManagerController : Controller
    {

        List<Departmen> departmens = new List<Departmen>()
    {
        new Departmen(){Id=1,DepartmenName="Ihracat"},
        new Departmen(){Id=2,DepartmenName="Muhasebe"},
        new Departmen(){Id=3,DepartmenName="Ithalat"},
        new Departmen(){Id=4,DepartmenName="Satış"}
    };

         

        [HttpPost]
        public IActionResult AddManager(Manager managers)
        {
            ViewBag.Departmens = departmens;
            return View();
        }
         
        public IActionResult AddManager()
        {
            ViewBag.Departmens = departmens;
            Manager manager = new Manager();
            manager.FirstName = "Ugur";
            manager.LastName = "Şeşen";
            manager.DepartmenId = "3";
            return View(manager);
        }

        public IActionResult AddManagerUsingTuple()
        {
            (List<Departmen>, Manager) tuple = (departmens, new Manager());
            return View(tuple);
        }

        [HttpPost]
        public IActionResult AddManagerUsingTuple([Bind(Prefix = "Item2")] Manager manager)
        {       
            
            return  RedirectToAction("AddManagerUsingTuple");
        }
    }
}
