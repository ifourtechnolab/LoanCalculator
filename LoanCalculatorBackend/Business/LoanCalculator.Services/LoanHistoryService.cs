using LoanCalculator.Domain.Models;
using LoanCalculator.Interfaces.Services;
using LoanCalculator.UoW;
using System.Threading.Tasks;

namespace LoanCalculator.Services
{
    public class LoanHistoryService : ServiceBase, ILoanHistoryService
    {
        public LoanHistoryService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<bool> AddAsync(LoanHistory model)
        {
            await unitOfWork.LoanHistoryRepository.AddAsync(model);
            return await Task.FromResult(true);
        }
    }
}