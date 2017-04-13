using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StarterFileExam2.Models;

namespace StarterFileExam2.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult InventoryList(string make)
        {
            ICarRepository repository = new EFCarRepository();
            IEnumerable<Car> Cars = repository.Cars;

            return View(Cars);

        }
    }
}