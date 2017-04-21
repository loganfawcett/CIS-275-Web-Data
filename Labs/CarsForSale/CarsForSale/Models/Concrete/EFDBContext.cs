using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CarsForSale.Models.Concrete;

namespace CarsForSale.Models.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}