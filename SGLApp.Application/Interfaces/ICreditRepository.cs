using SGLApp.Domain.Entities;

namespace SGLApp.Application.Interfaces
{
    public interface ICreditRepository
    {
        Task<List<Credit>> GetAllCredits();
        Task<Credit> GetCreditById(int id);     
        Task AddCredit(Credit newCredit);
        Task<Credit> UpdateCredit(Credit updatedCredit);
        Task<List<Credit>> DeleteCredit(int id);
    }
}
