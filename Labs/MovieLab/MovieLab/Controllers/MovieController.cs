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
        public int PageSize = 3;
        private IMovieRepository repository;
        public MovieController(IMovieRepository repos)
        {
            repository = repos;
        }
        // GET: Movie
        public ActionResult MovieList(int page = 1)
        {
            MoviesListViewModel model = new MoviesListViewModel
            {
                Movies = repository.Movies
                    .OrderBy(p => p.MovieID)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Movies.Count()
                }
            };
            return View(model);
        }
    }
}