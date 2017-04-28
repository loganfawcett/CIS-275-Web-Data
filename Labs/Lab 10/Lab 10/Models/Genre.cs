using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab_10.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        [DisplayName("Genre")]
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}