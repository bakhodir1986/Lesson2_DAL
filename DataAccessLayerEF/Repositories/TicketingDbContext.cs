using DataAccessLayerEF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerEF.Repositories
{
    public class TicketingContext : DbContext, ITicketingContext
    {
        public TicketingContext(DbContextOptions<TicketingContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }

        public DbSet<Events> Events { get; set; }

        public DbSet<Tickets> Tickets { get; set; }

        public DbSet<Prices> Prices { get; set; }

        public DbSet<Offers> Offers { get; set; }

        public DbSet<Seats> Seats { get; set; }

        public DbSet<Venues> Venues { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
