﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lab_10.Models
{
    public class Lab_10Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Lab_10Context() : base("name=Lab_10Context")
        {
        }

        public System.Data.Entity.DbSet<Lab_10.Models.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<Lab_10.Models.Movie> Movies { get; set; }

        public System.Data.Entity.DbSet<Lab_10.Models.Rating> Ratings { get; set; }
    }
}
