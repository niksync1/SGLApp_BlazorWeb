using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGLApp.Domain.Entities
{
    public class WinningTicket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WinningTicket_Id { get; set; }
        public DateTime? Sale { get; set; }
        public DateTime? Upload { get; set; }
        public int Agent_code { get; set; } = 1;
        public int Terminal_Sale { get; set; }
        public string? Ticket_Id { get; set; }
        public decimal? Payout { get; set; }
        public string? Ticket_Details { get; set; }
        public string? Ticket_Code { get; set; }
    }
}
