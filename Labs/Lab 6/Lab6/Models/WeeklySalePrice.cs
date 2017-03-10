using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab6.Models;

namespace Lab6.Models
{
    public class WeeklySalePrice : IPriceCalculator
    {
        public decimal CalcSalesPrice(decimal origPrice)
        {
              return origPrice * .95M;
        }
    }
}