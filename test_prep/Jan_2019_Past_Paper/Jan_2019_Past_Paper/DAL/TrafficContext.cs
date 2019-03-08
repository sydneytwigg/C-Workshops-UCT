using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jan_2019_Past_Paper.Models;
using System.Data.Entity;

namespace Jan_2019_Past_Paper.DAL
{
    public class TrafficContext : DbContext
    {
        public TrafficContext() : base("TrafficContext") { }

        public DbSet<Fine> Fine { get; set; }
    }
}