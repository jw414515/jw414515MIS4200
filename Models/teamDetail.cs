using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jw414515MIS4200.Models
{
    public class teamDetail
    {
        public int teamDetailID { get; set; }
        public decimal worth { get; set; }

        public int teamID { get; set; }
        public virtual Team Team { get; set; }
        public int playerID { get; set; }
        public virtual Player Player { get; set; }


    }
}