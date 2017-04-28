using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieLab.Models;

namespace MovieLab.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Movie> Movies
        {
            get { return context.Movies; }
        }
              
    }
}