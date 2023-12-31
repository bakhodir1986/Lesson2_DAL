using DataAccessLayerEF.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayerEF.Repositories
{
    public interface ITicketingContext
    {
        DbSet<Events> Events { get; set; }
        DbSet<Offers> Offers { get; set; }
        DbSet<Prices> Prices { get; set; }
        DbSet<Seats> Seats { get; set; }
        DbSet<Tickets> Tickets { get; set; }
        DbSet<Users> Users { get; set; }
        DbSet<Venues> Venues { get; set; }

        int SaveChanges();
    }
}