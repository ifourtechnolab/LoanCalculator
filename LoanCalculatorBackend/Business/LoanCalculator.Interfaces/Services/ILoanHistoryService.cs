using LoanCalculator.Domain.Models;
using System.Threading.Tasks;

namespace LoanCalculator.Interfaces.Services
{
    public interface ILoanHistoryService : IBaseService<LoanHistory>
    {
        Task<bool> AddAsync(LoanHistory model);
    }
}