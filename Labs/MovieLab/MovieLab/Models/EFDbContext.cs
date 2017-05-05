using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MovieLab.Models
{
    public class EFDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}