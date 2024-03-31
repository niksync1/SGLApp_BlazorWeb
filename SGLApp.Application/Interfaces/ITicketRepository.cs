using SGLApp.Domain.Entities;

namespace SGLApp.Application.Interfaces
{
    public interface ITicketRepository
    {
        Task<List<Ticket>> GetAllTickets();
        Task<Ticket?> GetTicketById(int id);
        Task<Ticket?> GetTicketByNum(string Ticketnum);
        Task AddTicketAsync(Ticket ticket);
        Task UpdateTicket(Ticket updatedTicket);
        //Task<List<Ticket>> DeleteTicket(int id);
        //Task<Ticket> CancelTicket(Ticket cancelledTicket);

    }
}
