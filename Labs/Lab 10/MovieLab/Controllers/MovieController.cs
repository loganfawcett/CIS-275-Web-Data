using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieLab.Models;

namespace MovieLab.Controllers
{
    public class MovieController : Controller
    {
        private IMovieRepository repository;
        public MovieController(IMovieRepository repos)
        {
            repository = repos;
        }
        // GET: Movie
        public ActionResult MovieList()
        {
            return View(repository.Movies);
        }
    }
}