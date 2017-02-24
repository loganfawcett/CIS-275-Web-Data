using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Test1.Models
{
    public class Car
    {
        [Required(ErrorMessage = "Please enter a make.")]
        public string Make { get; set; }
        [Required(ErrorMessage = "Please enter a model.")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Please enter a price.")]
        public double Price { get; set; }
        public int Milage { get; set; }
        [Required(ErrorMessage = "Please enter a year.")]
        public int Year { get; set; }
    }
}