using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            Person person = new Person();//created object of our model
            person.name = "Kv S Arora";
            person.age = 27;
            person.country = "India";
            person.email = "kvsarora@gmail.com";
            return View(person);
        }
        public IActionResult Update(Person person)
        {
            if (ModelState.IsValid)
            {
                return View(person);
            }
            else
            {
                return View(person);
            }
        }
    }
}
