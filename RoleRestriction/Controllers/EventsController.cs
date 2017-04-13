using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RoleRestriction.Models;

namespace RoleRestriction.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        private ApplicationDbContext _context;
        public EventsController()
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
            var events = _context.Events.ToList();
            return View(events);
        }

        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Event viewEvent)
        {
            if(viewEvent.Id==0)
            {
                _context.Events.Add(viewEvent);
            }
            else
            {
                var eventiInDb = _context.Events.Single(e => e.Id == viewEvent.Id);
                eventiInDb.EventType = viewEvent.EventType;
                eventiInDb.Starring = viewEvent.Starring;
                eventiInDb.Venue = viewEvent.Venue;
                eventiInDb.NoOfTickets = viewEvent.NoOfTickets;
            }
            _context.SaveChanges();
            return RedirectToAction("Index","Events");
        }

        public ActionResult Details(int id)
        {
            var eve = _context.Events.SingleOrDefault(e => e.Id==id);
            if (eve == null)
            {
                return Content("Bad request");
            }
            return View("New", eve);
        }

        public ActionResult Delete(int id)
        {
            var eve=_context.Events.SingleOrDefault(e=>e.Id==id);
            _context.Events.Remove(eve);
            _context.SaveChanges();
            return RedirectToAction("Index","Events");
        }
    }
}