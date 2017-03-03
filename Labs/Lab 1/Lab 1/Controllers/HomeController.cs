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
        string Date = DateTime.Now.ToString("MM/dd/yyyy");

        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Date = Date;

            return View();
        }
    }
}