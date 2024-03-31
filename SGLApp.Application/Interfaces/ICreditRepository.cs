using SGLApp.Domain.Entities;

namespace SGLApp.Application.Interfaces
{
    public interface ICreditRepository
    {
        Task<List<Credit>> GetAllCredits();
        Task<Credit?> GetCreditById(int id);     
        Task AddCreditAsync(Credit credit);
        Task UpdateCredit(Credit updatedCredit);
        //Task<Credit> DeleteCredit(int id);
    }
}
