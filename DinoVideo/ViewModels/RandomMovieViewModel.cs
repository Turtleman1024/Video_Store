using DinoVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DinoVideo.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customers> Customer {get; set;}
    }
}