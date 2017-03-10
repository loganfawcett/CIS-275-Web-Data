using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_5.Models;

namespace Lab_5.Controllers
{
    public class HomeController : Controller
    {
        Car[] myCars = {
                new Car {   Name = "Subaru Outback XT",         Year = 2005,    Cylinders = 4,      Price = 6500.00M},
                new Car {   Name = "Dodge Viper",               Year = 2003,    Cylinders = 10,     Price = 9000.00M},
                new Car {   Name = "Nissan GTR",                Year = 2017,    Cylinders = 6,      Price = 120000.00M},
                new Car {   Name = "Lamborghini Murcielago",    Year = 2005,    Cylinders = 10,     Price = 190000.00M},
                new Car {   Name = "Ford Shelby GT500",         Year = 2017,    Cylinders = 8,      Price = 53000.00M},
                new Car {   Name = "Bugatti Veyron",            Year = 2017,    Cylinders = 16,     Price = 2700000.00M},
                new Car {   Name = "Pontiac GrandAm",           Year = 2002,    Cylinders = 6,      Price = 2400.00M},
                new Car {   Name = "Toyota 86",                 Year = 2017,    Cylinders = 4,      Price = 26000.00M},
                new Car {   Name = "Koenigsegg One",            Year = 2013,    Cylinders = 8,      Price = 4200000.00M}
            };
        // GET: Home
        public ActionResult Index()
        {
            return View(myCars);
        }
    }
}