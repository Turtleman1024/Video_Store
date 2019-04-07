using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DinoVideo.Models;

namespace DinoVideo.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Jurassic Park" };

            var viewResult = new ViewResult();
            return View(movie);

        }

        //Attribute route
        [Route("movies/released/{year}/{month:regex(\\d{4):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year +  "/" + month);
        }
    }
}