using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RoleRestriction.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        [Display(Name= "Number of copies available")]
        public int AvailableSeats { get; set; }
        [Display(Name = "Booking Date")]
        public DateTime DateToBook { get; set; }
    }
}