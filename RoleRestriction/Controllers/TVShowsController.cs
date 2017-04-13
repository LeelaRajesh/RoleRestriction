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

        [HttpGet]
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
            if(tvShow.Id==0)
            {
                _context.TVShows.Add(tvShow);
            }
            else
            {
                var tvShowInDb = _context.TVShows.Single(t => t.Id == tvShow.Id);
                tvShowInDb.Name = tvShow.Name;
                tvShowInDb.Genre = tvShow.Genre;
                tvShowInDb.NoOfSeasons = tvShow.NoOfSeasons;
                tvShowInDb.EpisodesPerSeason = tvShow.EpisodesPerSeason;
                tvShowInDb.Region = tvShow.Region;
            }
            _context.SaveChanges();
            return RedirectToAction("Index","TVShows");
        }

        public ActionResult Details(int id)
        {
            var tvShow = _context.TVShows.SingleOrDefault(t => t.Id == id);
            return View("New",tvShow);
        }

        public ActionResult Delete(int id)
        {
            var tvShow=_context.TVShows.Single(t=>t.Id==id);
            _context.TVShows.Remove(tvShow);
            _context.SaveChanges();
            return RedirectToAction("Index","TVShows");
        }
    }
}