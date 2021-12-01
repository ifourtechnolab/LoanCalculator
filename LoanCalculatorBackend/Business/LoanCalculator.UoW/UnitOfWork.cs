using LoanCalculator.Domain;
using LoanCalculator.Interfaces.Repositories;
using LoanCalculator.Repositories;
using System;

namespace LoanCalculator.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LoanCalculatorContext Context;

        public UnitOfWork(LoanCalculatorContext context)
        {
            this.Context = context;
            LoanHistoryRepository = new LoanHistoryRepository(Context);
        }

        public ILoanHistoryRepository LoanHistoryRepository { get; }

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                Context.Dispose();
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}