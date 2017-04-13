using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RoleRestriction.Models
{
    public class TVShow
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "No Of Seasons")]
        public int NoOfSeasons { get; set; }

        [Display(Name="Episodes Per Season")]
        public int EpisodesPerSeason { get; set; }
        public string Genre { get; set; }
        public string Region { get; set; }
    }
}