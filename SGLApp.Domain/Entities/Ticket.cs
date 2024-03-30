using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SGLApp.Domain.Entities
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RealTimeTicket_Id { get; set; }
        public string? POSID { get; set; }
        public int? DrawNo { get; set; }
        public DateTime? DrawDate { get; set; }
        public DateTime? SalesDate { get; set; }
        public string? TicketNumber { get; set; }
        public string? ProductCode { get; set; }
        public string? Region { get; set; }
        public string? RetailerID { get; set; }
        public string? GameCode { get; set; }
        public string? PermNumber { get; set; }
        public string? PermBet { get; set; }
        public string? PermWeight { get; set; }
        public decimal? PermAmount { get; set; }
        public string? DirectNumber { get; set; }
        public string? DirectBet { get; set; }
        public string? DirectWeight { get; set; }
        public decimal? DirectAmount { get; set; }
        public string? FullTicket { get; set; }
        public decimal? TotalAmount { get; set; }
        public string? IMEI { get; set; }
        public decimal? POSBalance { get; set; }
        public DateTime? POSDateTime { get; set; }
        public string? EncryptedData { get; set; }
        public string? Key { get; set; }
        public string? PhoneNetwork { get; set; }
        public string? PhoneNumber { get; set; }
        public int? SalesSynced { get; set; } = 0;
        public bool? Canceled { get; set; }
    }
}
