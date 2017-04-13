using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoleRestriction.Models
{
    public class TVShow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NoOfSeasons { get; set; }
        public int EpisodesPerSeason { get; set; }
        public string Genre { get; set; }
        public string Region { get; set; }
    }
}