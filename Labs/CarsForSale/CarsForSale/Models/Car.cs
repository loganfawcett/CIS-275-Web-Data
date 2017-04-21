﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsForSale.Models
{
    public class Car
    {
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public int Year { get; set; }
        public int Miles { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
    }
}