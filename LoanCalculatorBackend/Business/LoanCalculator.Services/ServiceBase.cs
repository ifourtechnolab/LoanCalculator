using LoanCalculator.UoW;
using System;

namespace LoanCalculator.Services
{
    public abstract class ServiceBase : IDisposable
    {
        protected readonly IUnitOfWork unitOfWork;

        protected ServiceBase(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing) unitOfWork.Dispose();

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~ServiceBase()
        {
            Dispose(false);
        }
    }
}