using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_002
{
    public class MyDbContex : DbContext
    {
        public MyDbContex() : base("DbConnectionString")
        {
        }
        
        public DbSet<Ticket> Tickets {  get; set; }
        public DbSet<Trip> Trips { get; set; }

    }
}
