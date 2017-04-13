using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RoleRestriction.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Display(Name="Event Type")]
        public string EventType { get; set; }
        public string Starring { get; set; }
        public string Date { get; set; }
        public string Venue { get; set; }
        [Display(Name="Tickets Available")]
        public int NoOfTickets { get; set; }
    }
}