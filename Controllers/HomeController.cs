using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTauranteer.Models;

namespace RESTauranteer.Controllers
{
    public class HomeController : Controller
    {
        private RestContext _context;

        public HomeController(RestContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Review r)
        {
            if(ModelState.IsValid)
            {
                _context.Add(r);
                _context.SaveChanges();
                return RedirectToAction("ShowReviews");
            }
            return View("Index");
        }

        [HttpGet]
        [Route("reviews")]
        public IActionResult ShowReviews()
        {
            List<Review> reviews = _context.Reviews.ToList();
            reviews.Reverse();
            return View(reviews);
        }

    }
}
