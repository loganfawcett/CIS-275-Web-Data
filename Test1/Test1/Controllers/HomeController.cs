using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult carForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult carForm(Car car)
        {
            if (ModelState.IsValid)
            {
                return View("Complete", car);
            }
            else
            {
                return View();
            }
        }
    }
}