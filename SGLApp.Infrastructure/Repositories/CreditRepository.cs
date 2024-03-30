using Microsoft.EntityFrameworkCore;
using SGLApp.Application.Interfaces;
using SGLApp.Domain.Entities;
using SGLApp.Infrastructure.Context;

namespace SGLApp.Infrastructure.Repositories
{
    public class CreditRepository : ICreditRepository
    {
        private readonly SGLAppDbContext context;
        public CreditRepository(IDbContextFactory<SGLAppDbContext> factory)
        {
            context = factory.CreateDbContext();
        }

        public async Task AddCredit(Credit newCredit)
        {
            context.CreditTransmissions.Add(newCredit);
            await context.SaveChangesAsync();
        }

        public Task<List<Credit>> DeleteCredit(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Credit>> GetAllCredits()
        {
            throw new NotImplementedException();
        }

        public Task<Credit> GetCreditById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Credit> UpdateCredit(Credit updatedCredit)
        {
            throw new NotImplementedException();
        }
    }
}
