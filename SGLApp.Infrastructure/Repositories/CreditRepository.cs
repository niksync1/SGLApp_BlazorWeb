using Microsoft.EntityFrameworkCore;
using SGLApp.Application.Interfaces;
using SGLApp.Infrastructure.Context;
using SGLApp.Domain.Entities;

namespace SGLApp.Infrastructure.Repositories
{
    public class CreditRepository : ICreditRepository
    {
        private readonly SGLAppDbContext context;
        public CreditRepository(IDbContextFactory<SGLAppDbContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task AddCreditAsync(Credit credit)
        {
            context.CreditTransmissions.Add(credit);
            await context.SaveChangesAsync();
        }

        //public Task<Credit> DeleteCredit(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<List<Credit>> GetAllCredits()
        {
            var dbCredits = await context.CreditTransmissions.ToListAsync();
            return dbCredits;
        }

        public async Task<Credit?> GetCreditById(int id)
        {
            var dbCredit = await context.CreditTransmissions.FirstOrDefaultAsync(e =>e.Auto_Id == id);
            return dbCredit;
        }

        public async Task UpdateCredit(Credit updatedCredit)
        {
            context.Entry(UpdateCredit).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
