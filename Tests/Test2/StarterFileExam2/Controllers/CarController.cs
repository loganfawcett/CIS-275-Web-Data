using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StarterFileExam2.Models;
using System.Linq;
using StarterFileExam2.Infrastructure;

namespace StarterFileExam2.Controllers
{
    public class CarController : Controller
    {
        NinjectDependencyResolver res;
        // GET: Car
        public ActionResult InventoryList(string make)
        {
            ICarRepository repository = new EFCarRepository();
            IEnumerable<Car> Cars = repository.Cars.OrderBy(x => x.Miles);

            return View(Cars);

        }
    }
}