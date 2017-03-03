using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_1.Models;

namespace Lab_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string Date = DateTime.Now.ToString("MM/dd/yyyy");

            ViewBag.Date = Date;

            return View();
        }

        [HttpGet]
        public ActionResult SignupForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignupForm(UserInfo userInfo)
        {
            return View("Thanks", userInfo);
        }
    }
}