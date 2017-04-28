using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_10.Models
{
    public class Rating
    {
        public int RatingID { get; set; }
        [DisplayName("Rating")]
        public String Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}