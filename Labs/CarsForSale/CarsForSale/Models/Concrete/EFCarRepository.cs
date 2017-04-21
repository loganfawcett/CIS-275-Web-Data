using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarsForSale.Models.Abstract;
using CarsForSale.Models.Concrete;

namespace CarsForSale.Models.Concrete
{
    public class EFCarRepository : ICarRepository
    {
        public EFDbContext context = new EFDbContext();
        public IEnumerable<Car> Cars
        {
            get { return context.Cars; }
        }
    }
}