using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = GetMovies().SingleOrDefault(c => c.MovieID == id);
            return View(movies);
        }
        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>{

                new Movie{MovieID = 1, MovieName = "Die Hard"},
                new Movie{MovieID = 2, MovieName = "Fawda"}
            };
        }
    }

}