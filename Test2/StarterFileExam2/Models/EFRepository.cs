using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StarterFileExam2.Models
{
    public class EFCarRepository : ICarRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Car> Cars
        {
            get { return context.Cars; }
        }
    }
}