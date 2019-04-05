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
    }
}