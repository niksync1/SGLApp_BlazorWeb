using SGLApp.Domain.Entities;

namespace SGLApp.Application.Interfaces
{
    public interface IWinningTicketRepository
    {
        Task<List<WinningTicket>> GetAllWinningTickets();
        Task<WinningTicket> GetWinningTicketById(string Ticket_Id);
        Task AddWinningTicket(Ticket newWinningTicket);
        Task<WinningTicket> UpdateWinningTicket(Ticket updateWinningTicket);
    }
}
