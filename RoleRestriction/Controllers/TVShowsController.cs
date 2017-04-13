using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoleRestriction.Models;

namespace RoleRestriction.Controllers
{
    public class TVShowsController : Controller
    {
        // GET: TVShows
        private ApplicationDbContext _context;
        public TVShowsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var TVShows = _context.TVShows.ToList();
            return View(TVShows);
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(TVShow tvShow)
        {
            _context.TVShows.Add(tvShow);
            _context.SaveChanges();
            return RedirectToAction("Index","TVShows");
        }
    }
}