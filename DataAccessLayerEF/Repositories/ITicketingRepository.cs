using DataAccessLayerEF.Models;

namespace DataAccessLayerEF.Repositories
{
    public interface ITicketingRepository
    {
        IQueryable<Events> Events { get; }
        IQueryable<Offers> Offers { get; }
        IQueryable<Prices> Prices { get; }
        IQueryable<Seats> Seats { get; }
        IQueryable<Tickets> Tickets { get; }
        IQueryable<Users> Users { get; }
        IQueryable<Venues> Venues { get; }

        void AddEvent(Events events);
        void AddOffers(Offers item);
        void AddPrices(Prices item);
        void AddSeats(Seats item);
        void AddTickets(Tickets item);
        void AddUsers(Users item);
        void AddVenues(Venues item);
        void RemoveEvent(Events events);
        void RemoveOffers(Offers item);
        void RemovePrices(Prices item);
        void RemoveSeats(Seats item);
        void RemoveTickets(Tickets item);
        void RemoveUsers(Users item);
        void RemoveVenues(Venues item);
        void UpdateEvent(Events events);
        void UpdateOffers(Offers item);
        void UpdatePrices(Prices item);
        void UpdateSeats(Seats item);
        void UpdateTickets(Tickets item);
        void UpdateUsers(Users item);
        void UpdateVenues(Venues item);
    }
}