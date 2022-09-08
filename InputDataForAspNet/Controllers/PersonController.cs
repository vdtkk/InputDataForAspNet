using InputDataForAspNet.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InputDataForAspNet.Controllers
{
    public class PersonController : Controller
    {

        List<Person> persons = new List<Person>()
            {
                new Person(){PersonName="uğur",PersonSurName="şeşen" },
                new Person(){PersonName="Ahmet",PersonSurName="Çalışkan" },
                new Person(){PersonName="Vedat",PersonSurName="Kıvrak" }
            };

        public IActionResult GetPersonList()
        {
            return View(persons);
        }

        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            persons.Add(person);
            return View("GetPersonList", persons);
        }
    }
}
