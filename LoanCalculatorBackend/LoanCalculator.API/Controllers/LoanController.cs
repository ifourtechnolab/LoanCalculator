using LoanCalculator.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace LoanCalculator.API.Controllers
{
    [Route("api/[controller]")]
    public class LoanController : BaseApiController
    {
        private readonly ILoanHistoryService _loanHistoryService;
       

        public LoanController(ILoanHistoryService loanHistoryService)
        {
            _loanHistoryService = loanHistoryService;
        }

        [HttpGet]
        public async Task<object> CalculateLvr(double propertyValue, double amount)
        {
            return await GetDataWithMessage(async () =>
            {
                double result = propertyValue != 0 && amount != 0 ? (amount / propertyValue) * 100 : 0;
                await _loanHistoryService.AddAsync(new Domain.Models.LoanHistory 
                {
                    Amount = (decimal)amount,
                    PropertyValue = (decimal)propertyValue,
                    Result = (decimal)result,
                    CreatedDate = DateTime.Now
                });
                return Response(result, string.Empty);
            });
        }
    }
}