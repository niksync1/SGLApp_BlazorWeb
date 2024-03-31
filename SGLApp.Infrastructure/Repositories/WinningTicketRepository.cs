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

        public async Task AddWinningTicketAsync(WinningTicket WinningTicket)
        {
            context.WinningTickets.Add(WinningTicket);
            await context.SaveChangesAsync();
        }

        public Task<List<WinningTicket>> GetAllWinningTickets()
        {
            throw new NotImplementedException();
        }

        public Task<WinningTicket> GetWinningTicketById(string Ticket_Id)
        {
            throw new NotImplementedException();
        }

        public Task<WinningTicket> UpdateWinningTicket(WinningTicket updateWinningTicket)
        {
            throw new NotImplementedException();
        }
    }
}
