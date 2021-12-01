using LoanCalculator.Domain;
using LoanCalculator.Domain.Models;
using LoanCalculator.Interfaces.Repositories;

namespace LoanCalculator.Repositories
{
    public class LoanHistoryRepository : BaseRepository<LoanHistory>, ILoanHistoryRepository
    {
        public LoanHistoryRepository(LoanCalculatorContext context) : base(context)
        {
        }
    }
}