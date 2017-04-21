using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarsForSale.Models.Abstract;

namespace CarsForSale.Controllers
{
    public class CarController : Controller
    {
        private ICarRepository repo;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InventoryList()
        {
            return View(repo.Cars);
        }
    }
}