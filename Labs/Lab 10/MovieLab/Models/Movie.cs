using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieLab.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public String Name { get; set; }
        public String Rating { get; set; }
        public String Genre { get; set; }
    }
}