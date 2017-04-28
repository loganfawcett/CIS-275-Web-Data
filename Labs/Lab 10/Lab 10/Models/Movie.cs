using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_10.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string Name { get; set; }
        public string RatingID { get; set; }
        public virtual Rating Rating { get; set; }
        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }
    }
}