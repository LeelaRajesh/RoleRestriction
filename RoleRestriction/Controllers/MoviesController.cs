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
        public ActionResult Index()
        {
            var movieslist = _context.Movies.ToList();
            return View(movieslist);
        }


        public ActionResult New()
        {
            return View();
        }

        public ActionResult Create(Movie newMovie)
        {
            _context.Movies.Add(newMovie);
            _context.SaveChanges();

            return RedirectToAction("Index","Movies");
        }
    }
}