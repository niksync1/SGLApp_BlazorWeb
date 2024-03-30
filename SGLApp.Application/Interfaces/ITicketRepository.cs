using SGLApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGLApp.Application.Interfaces
{
    public interface ITicketRepository
    {
        Task<List<Ticket>> GetAllTickets();
        Task<Ticket> GetTicketById(int id);
        Task<Ticket> GetTicketByNum(string Ticketnum);
        Task AddTicket(Ticket newTicket);
        Task<Ticket> UpdateTicket(Ticket updatedTicket);
        Task<List<Ticket>> DeleteTicket(int id);
        Task<Ticket> CancelTicket(Ticket cancelledTicket);

    }
}
