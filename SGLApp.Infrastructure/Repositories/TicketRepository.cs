using Microsoft.EntityFrameworkCore;
using SGLApp.Application.Interfaces;
using SGLApp.Infrastructure.Context;
using SGLApp.Domain.Entities;

namespace SGLApp.Infrastructure.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly SGLAppDbContext context;
        public TicketRepository(IDbContextFactory <SGLAppDbContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task AddTicketAsync(Ticket newTicket)
        {
           context.RealTimeTickets.Add(newTicket);
            await context.SaveChangesAsync();
        }
        //public Task<Ticket> CancelTicket(Ticket cancelledTicket)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<Ticket>> DeleteTicket(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<List<Ticket>> GetAllTickets()
        {
            var dbTickets = await context.RealTimeTickets.ToListAsync();
            return dbTickets;
        }

        public async Task<Ticket?> GetTicketById(int id)
        {
            var dbTicket = await context.RealTimeTickets.FirstOrDefaultAsync(e=> e.RealTimeTicket_Id == id);    
            return dbTicket;
        }
        public async Task<Ticket?> GetTicketByNum(string Ticketnum)
        {
            var dbTicket = await context.RealTimeTickets.FirstOrDefaultAsync(e => e.TicketNumber == Ticketnum);
            return dbTicket;
        }
        public async Task UpdateTicket(Ticket updatedTicket)
        {
            context.Entry(UpdateTicket).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
