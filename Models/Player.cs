using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jw414515MIS4200.Models
{
    public class Player
    {
        public int playerID { get; set; }
        public string position { get; set; }
        public decimal salary { get; set; }
        public ICollection<teamDetail> TeamDetails { get; set; }


    }
}