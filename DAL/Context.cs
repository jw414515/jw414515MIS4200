using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using jw414515MIS4200.Models;
using System.Data.Entity;

namespace jw414515MIS4200.DAL
{
    public class Context : DbContext
    {
        public Context() : base ("name=DefaultConnection")
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<teamDetail> TeamDetails { get; set; }
    }
}