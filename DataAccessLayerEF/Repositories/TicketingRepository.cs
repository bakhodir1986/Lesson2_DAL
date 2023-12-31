using DataAccessLayerEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerEF.Repositories
{
    public class TicketingRepository : ITicketingRepository
    {
        private ITicketingContext _ticketingContext;

        public TicketingRepository(ITicketingContext ticketingContext)
        {

            _ticketingContext = ticketingContext;
        }

        #region Events
        public void AddEvent(Events events)
        {
            if (events == null) return;

            _ticketingContext.Events.Add(events);
            _ticketingContext.SaveChanges();
        }

        public void RemoveEvent(Events events)
        {
            if (events == null) return;
            _ticketingContext.Events.Remove(events);
            _ticketingContext.SaveChanges();
        }

        public void UpdateEvent(Events events)
        {
            if (events == null) return;
            _ticketingContext.Events.Update(events);
            _ticketingContext.SaveChanges();
        }

        public IQueryable<Events> Events => _ticketingContext.Events;

        #endregion

        #region Offers
        public void AddOffers(Offers item)
        {
            if (item == null) return;

            _ticketingContext.Offers.Add(item);
            _ticketingContext.SaveChanges();
        }

        public void RemoveOffers(Offers item)
        {
            if (item == null) return;
            _ticketingContext.Offers.Remove(item);
            _ticketingContext.SaveChanges();
        }

        public void UpdateOffers(Offers item)
        {
            if (item == null) return;
            _ticketingContext.Offers.Update(item);
            _ticketingContext.SaveChanges();
        }

        public IQueryable<Offers> Offers => _ticketingContext.Offers;
        #endregion

        #region Prices
        public void AddPrices(Prices item)
        {
            if (item == null) return;

            _ticketingContext.Prices.Add(item);
            _ticketingContext.SaveChanges();
        }

        public void RemovePrices(Prices item)
        {
            if (item == null) return;
            _ticketingContext.Prices.Remove(item);
            _ticketingContext.SaveChanges();
        }

        public void UpdatePrices(Prices item)
        {
            if (item == null) return;
            _ticketingContext.Prices.Update(item);
            _ticketingContext.SaveChanges();
        }

        public IQueryable<Prices> Prices => _ticketingContext.Prices;

        #endregion

        #region Seats
        public void AddSeats(Seats item)
        {
            if (item == null) return;

            _ticketingContext.Seats.Add(item);
            _ticketingContext.SaveChanges();
        }

        public void RemoveSeats(Seats item)
        {
            if (item == null) return;
            _ticketingContext.Seats.Remove(item);
            _ticketingContext.SaveChanges();
        }

        public void UpdateSeats(Seats item)
        {
            if (item == null) return;
            _ticketingContext.Seats.Update(item);
            _ticketingContext.SaveChanges();
        }

        public IQueryable<Seats> Seats => _ticketingContext.Seats;

        #endregion

        #region Tickets
        public void AddTickets(Tickets item)
        {
            if (item == null) return;

            _ticketingContext.Tickets.Add(item);
            _ticketingContext.SaveChanges();
        }

        public void RemoveTickets(Tickets item)
        {
            if (item == null) return;
            _ticketingContext.Tickets.Remove(item);
            _ticketingContext.SaveChanges();
        }

        public void UpdateTickets(Tickets item)
        {
            if (item == null) return;
            _ticketingContext.Tickets.Update(item);
            _ticketingContext.SaveChanges();
        }

        public IQueryable<Tickets> Tickets => _ticketingContext.Tickets;

        #endregion

        #region Users
        public void AddUsers(Users item)
        {
            if (item == null) return;

            _ticketingContext.Users.Add(item);
            _ticketingContext.SaveChanges();
        }

        public void RemoveUsers(Users item)
        {
            if (item == null) return;
            _ticketingContext.Users.Remove(item);
            _ticketingContext.SaveChanges();
        }

        public void UpdateUsers(Users item)
        {
            if (item == null) return;
            _ticketingContext.Users.Update(item);
            _ticketingContext.SaveChanges();
        }

        public IQueryable<Users> Users => _ticketingContext.Users;

        #endregion

        #region Venues
        public void AddVenues(Venues item)
        {
            if (item == null) return;

            _ticketingContext.Venues.Add(item);
            _ticketingContext.SaveChanges();
        }

        public void RemoveVenues(Venues item)
        {
            if (item == null) return;
            _ticketingContext.Venues.Remove(item);
            _ticketingContext.SaveChanges();
        }

        public void UpdateVenues(Venues item)
        {
            if (item == null) return;
            _ticketingContext.Venues.Update(item);
            _ticketingContext.SaveChanges();
        }

        public IQueryable<Venues> Venues => _ticketingContext.Venues;

        #endregion
    }
}
