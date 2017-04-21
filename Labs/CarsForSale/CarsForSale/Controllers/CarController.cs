using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarsForSale.Models.Abstract;
using CarsForSale.Models;

namespace CarsForSale.Controllers
{
    public class CarController : Controller
    {
        private ICarRepository repo;
        public CarController(ICarRepository theseCars)
        {
            this.repo = theseCars;
        }

        public ActionResult InventoryList()
        {
            return View(repo.Cars);
        }
    }
}