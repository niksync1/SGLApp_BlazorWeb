using Microsoft.EntityFrameworkCore;
using SGLApp.Domain.Entities;

namespace SGLApp.Infrastructure.Context
{
    public class SGLAppDbContext : DbContext
    {
        public SGLAppDbContext(DbContextOptions<SGLAppDbContext> options) : base(options)
        {

        }

        //partial void OnModelBuilding(ModelBuilder builder);
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Credit>().ToTable(tb => tb.HasTrigger("CreditTransmissions"));
        //    builder.Entity<Ticket>().ToTable(tb => tb.HasTrigger("RealTimeTickets"));
        //    builder.Entity<WinningTicket>().ToTable(tb => tb.HasTrigger("WinningTickets"));

        //}

        public DbSet<Credit> CreditTransmissions { get; set; }
        public DbSet<Ticket> RealTimeTickets { get; set; }
        public DbSet<WinningTicket> WinningTickets { get; set; }
    }
}
