using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LoanCalculator.Domain.Models;

namespace LoanCalculator.Domain
{
    public partial class LoanCalculatorContext : IdentityDbContext
    {
        public LoanCalculatorContext(DbContextOptions<LoanCalculatorContext> options) : base(options)
        {
        }

        public DbSet<LoanHistory> LoanHistory { get; set; }


    }
}