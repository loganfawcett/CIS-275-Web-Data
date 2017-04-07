using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace DatabaseExample.Models
{
    public class EFDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}