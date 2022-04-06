using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        //profile
        //account
        //changepassword
        public IActionResult Index()
        {
            ViewBag.UName = "Kv Singh";
            ViewBag.UCountry = "India";
            ViewData["Org"] = "Koenig Solutions";
            return View();
        }
        public IActionResult GetValue(string id)
        {
            string myName = (string)RouteData.Values["id"];
            return Content($"Hi My name is {myName}");
        }
        public IActionResult ApiData()
        {
            return View("FetchApiData");
        }
    }
}
