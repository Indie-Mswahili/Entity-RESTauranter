using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTauranter.Models;

namespace RESTauranter.Controllers
{
    public class HomeController : Controller
    {
        private ReviewContext _context;

        public HomeController(ReviewContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            
            return View("Index");
        }

        [HttpGet]
        [Route("reviews")]
        public IActionResult ShowReviews()
        {
            // IEnumerable<Reviews> reviews = _context.Review;
            List<Reviews> reviews = _context.Reviews.ToList();
            return View("Review", reviews);
        }

        [HttpPost]
        [Route("AddReview")]
        public IActionResult AddAReview(Reviews uReview)
        {
            _context.Reviews.Add(uReview);
            _context.SaveChanges();
            return RedirectToAction("ShowReviews");
        }
    }
}