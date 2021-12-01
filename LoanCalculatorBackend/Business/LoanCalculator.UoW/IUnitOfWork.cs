using LoanCalculator.Interfaces.Repositories;
using System;

namespace LoanCalculator.UoW
{
    public interface IUnitOfWork : IDisposable
    {
        ILoanHistoryRepository LoanHistoryRepository { get; }
    }
}