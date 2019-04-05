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
            //Below are some example of Action Results
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //If you look in the address bar it will show page=1&sortby=name
            //return RedirectToAction("Index", "Home", new { page = 1, sortby = "name"});

            return View(movie);

        }

        /// <summary>
        /// Example of Action Parameters
        /// /movies/edit/1
        /// or 
        /// Query String example
        /// /movies/edit?id=1
        /// </summary>
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        /// <summary>
        /// Example of parameter Action
        /// Could return a view from the database
        /// GOTO:
        /// /movies
        /// Can Override by doing
        /// /movies?pageIndex=2&sortBy=ReleaseDate
        /// </summary>
        /// <param name="pageIndex">Is optional</param>
        /// <param name="sortby"></param>
        /// <returns>Could return a list of movies from DB</returns>
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        }
    }
}