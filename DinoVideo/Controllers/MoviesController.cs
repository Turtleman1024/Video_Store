using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DinoVideo.Models;
using DinoVideo.ViewModels;

namespace DinoVideo.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Jurassic Park" };
            var customers = new List<Customers>
            {
                new Customers { Id = 1, Name = "Steve Roger"},
                new Customers { Id = 2, Name = "Tony Stark"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customer = customers
            };
            
            return View(viewModel);

        }

        //Attribute route
        [Route("movies/released/{year}/{month:regex(\\d{4):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +  "/" + month);
        }
    }
}