using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie(1, "Shrek!");
            var customers = new List<Customer>
            {
                new Customer(1, "Customer 1"),
                new Customer(2, "Customer 2")
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie(1, "Shrek"),
                new Movie(2, "Tarzan")
            };
        }
    }
}