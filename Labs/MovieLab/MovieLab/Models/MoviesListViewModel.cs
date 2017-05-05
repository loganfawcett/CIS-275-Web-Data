using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieLab.Models
{
    public class MoviesListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}