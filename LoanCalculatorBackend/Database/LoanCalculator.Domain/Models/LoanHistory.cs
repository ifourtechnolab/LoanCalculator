using System;
using System.ComponentModel.DataAnnotations;

namespace LoanCalculator.Domain.Models
{
    public partial class LoanHistory : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public decimal PropertyValue { get; set; }

        public decimal Result { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}