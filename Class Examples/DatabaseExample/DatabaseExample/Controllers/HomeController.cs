using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatabaseExample.Models;

namespace DatabaseExample.Controllers
{
    public class HomeController : Controller
    {
        private IStudentRepository repository;
        public HomeController(IStudentRepository repos)
        {
            repository = repos;
        }

        // GET: Home
        public ActionResult Index()
        {
            return View(repository.Students);
        }
    }
}