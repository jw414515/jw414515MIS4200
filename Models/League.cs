using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jw414515MIS4200.Models
{
    public class League
    {
        public int leagueID { get; set; }
        public string leagueName { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public DateTime establishedIn { get; set; }
        public ICollection<Team> Team { get; set; }

    }
}