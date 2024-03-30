using Microsoft.EntityFrameworkCore;
using SGLApp.Application.Interfaces;
using SGLApp.Domain.Entities;
using SGLApp.Infrastructure.Context;

namespace SGLApp.Infrastructure.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly SGLAppDbContext context;
        public TicketRepository(IDbContextFactory <SGLAppDbContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task AddTicket(Ticket newTicket)
        {
           context.RealTimeTickets.Add(newTicket);
            await context.SaveChangesAsync();
        }

        public Task<Ticket> CancelTicket(Ticket cancelledTicket)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ticket>> DeleteTicket(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Ticket>> GetAllTickets()
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> GetTicketById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> GetTicketByNum(string Ticketnum)
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> UpdateTicket(Ticket updatedTicket)
        {
            throw new NotImplementedException();
        }
    }
}
