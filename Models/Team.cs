using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.ComponentModel.DataAnnotations;

namespace jw414515MIS4200.Models
{
    public class Team
    {
        public int teamID { get; set; }
        public string city { get; set; }
        public DateTime foundedIn { get; set; }

        public ICollection<teamDetail> TeamDetails { get; set; }

        public int leagueID { get; set; }
        public virtual  League  League { get; set; }

        //[Key]
        //public int teamID { get; set; }
    }
}