using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SGLApp.Domain.Entities
{
    public class Credit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Auto_Id { get; set; }
        public int? AgentNumber { get; set; }
        public string? transaction_reference { get; set; } = "";
        public DateTime? TransactionDate { get; set; }
        public decimal? Amount { get; set; } = 10;
        public int? Status { get; set; } = 0;
        public string? Vc { get; set; } = "";
        public DateTime? AuditDate { get; set; } = DateTime.Now;
        public string? BankName { get; set; }
        public string? BankBranch { get; set; }
    }
}
