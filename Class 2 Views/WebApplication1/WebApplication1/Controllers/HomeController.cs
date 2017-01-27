using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;

      //Conditional operators
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Evening";

      /*Normal way to do it
            if (hour < 12)
            {
                ViewBag.Greeting = "Good Morning!";
            }
            else
            {
                ViewBag.Greeting = "Good Morning!";
            }*/

            return View();
        }
    }
}