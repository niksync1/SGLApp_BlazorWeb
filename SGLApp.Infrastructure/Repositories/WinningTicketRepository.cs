using Microsoft.EntityFrameworkCore;
using SGLApp.Application.Interfaces;
using SGLApp.Domain.Entities;
using SGLApp.Infrastructure.Context;

namespace SGLApp.Infrastructure.Repositories
{
    public class WinningTicketRepository : IWinningTicketRepository
    {
        private readonly SGLAppDbContext context;
        public WinningTicketRepository(IDbContextFactory<SGLAppDbContext> factory)
        {
            context =factory.CreateDbContext();
        }

        public async Task AddWinningTicket(WinningTicket newWinningTicket)
        {
            context.WinningTickets.Add(newWinningTicket);
            await context.SaveChangesAsync();
        }

        public Task AddWinningTicket(Ticket newWinningTicket)
        {
            throw new NotImplementedException();
        }

        public Task<List<WinningTicket>> GetAllWinningTickets()
        {
            throw new NotImplementedException();
        }

        public Task<WinningTicket> GetWinningTicketById(string Ticket_Id)
        {
            throw new NotImplementedException();
        }

        public Task<WinningTicket> UpdateWinningTicket(Ticket updateWinningTicket)
        {
            throw new NotImplementedException();
        }
    }
}
