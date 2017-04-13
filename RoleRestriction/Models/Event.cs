using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoleRestriction.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string EventType { get; set; }
        public string Starring { get; set; }
        public string Date { get; set; }
        public string Venue { get; set; }
        public int NoOfTickets { get; set; }
    }
}