using DinoVideo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DinoVideo.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        // "/Customers/Index"
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        // "/Customers/Details/{int id}"
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if(customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Steve Roger"},
                new Customer { Id = 2, Name = "Tony Stark"}
            };
        }
    }
}