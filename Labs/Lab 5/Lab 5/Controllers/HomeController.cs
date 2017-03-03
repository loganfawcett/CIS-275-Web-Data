﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_5.Controllers
{
    public class HomeController : Controller
    {
        Car[] myCars = {
                new Car {   Make = "Subaru",      Model = "Outback XT",     Year = 2005,    Engine = "4-H",     Asperation = "Turbocharged" },
                new Car {   Make = "Dodge",       Model = "Viper",          Year = 2003,    Engine = "10-V",    Asperation = "N/A" },
                new Car {   Make = "Nissan",      Model = "GTR",            Year = 2017,    Engine = "6-V",     Asperation = "Turbocharged-Twin" },
                new Car {   Make = "Lamborghini", Model = "Murcielago",     Year = 2005,    Engine = "10-V",    Asperation = "N/A" },
                new Car {   Make = "Ford",        Model = "Shelby GT500",   Year = 2017,    Engine = "8-V",     Asperation = "Supercharged" },
                new Car {   Make = "Bugatti",     Model = "Veyron",         Year = 2017,    Engine = "16-W",    Asperation = "Turbocharged-Quad" }
            };

        // GET: Home
        public ActionResult Index()
        {
            return View(myCars[1]);
        }

        public ActionResult List()
        {
            return View(myCars);
        }
    }
}