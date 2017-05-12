using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace StarterFileExam2.Models
{
    public class EFDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}