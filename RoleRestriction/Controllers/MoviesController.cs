using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoleRestriction.Models;

namespace RoleRestriction.Controllers
{
    public class MoviesController : Controller
    {
        // GET: MovieModel
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public ActionResult Index()
        {
            var movieslist = _context.Movies.ToList();
            return View(movieslist);
        }


        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie newMovie)
        {
            if (!ModelState.IsValid)
            {
                return Content("error");
            }
            if(newMovie.Id==0)
            {
                _context.Movies.Add(newMovie);
            }
            else
            {
                var movieIndBD = _context.Movies.Single(m => m.Id == newMovie.Id);
                movieIndBD.Name = newMovie.Name;
                movieIndBD.Genre = newMovie.Genre;
                movieIndBD.DateToBook = newMovie.DateToBook;
                movieIndBD.AvailableSeats = newMovie.AvailableSeats;
                movieIndBD.Price = newMovie.Price;
            }
            _context.SaveChanges();

            return RedirectToAction("Index","Movies");
        }


        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return Content("No data found");
            }
            return View("New",movie);
        }

        public ActionResult Delete(int id)
        {
            var movie = _context.Movies.Single(m => m.Id == id);
            if(movie!=null)
            {
                _context.Movies.Remove(movie);
                _context.SaveChanges();
            }
            return RedirectToAction("Index","Movies");
        }
    }
}