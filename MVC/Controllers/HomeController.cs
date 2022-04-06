using Microsoft.AspNetCore.Mvc;
using MVC.FIlters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {            //ViewResult -> View
            //ContentResult -> 
            //RedirectToRouteResult
            //RedirectToActionResult
            //StatusCodeResult

        [Route("Koenig/ASP")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Koenig/About")]
        [SimpleActionFilter]
        public ViewResult AboutUs()
        {
            return View();
        }
        public ContentResult Message()
        {
            return Content("This is Default Message");
        }
        public StatusCodeResult NotFound()
        {
            /*
            100 - information
            200 - successful
            300 - redirection
            400 - client side error
            500 - server side error
             */
            return new StatusCodeResult(404);
        }
        public RedirectToActionResult Koenig()
        {
            return RedirectToAction("AboutUs");
        }
        public RedirectToRouteResult Profile()
        {
            return RedirectToRoute(
                new
                {
                    Controller = "User",
                    Action = "Index"
                });
        }
    }
}
