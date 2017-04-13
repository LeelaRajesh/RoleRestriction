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
        public ActionResult Index()
        {
            var events = _context.Events.ToList();
            return View(events);
        }
    }
}