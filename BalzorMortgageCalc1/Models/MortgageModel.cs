using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BalzorMortgageCalc1.Models
{
    public class MortgageModel
    {
        [Required]
        [Range(1, double.MaxValue, ErrorMessage ="Amount cannot be zero or negative")]
        public double PrincipalAmount { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage ="Number of payments cannot be zero or negative")]
        public int NumberMonthlyPayments { get; set; }
        [Required]
        public double InterestAPR { get; set; }
        public double InterestPerMonth { get; set; }
        public double MonthlyPaymentAmount { get; set; }
        public double TotalMortgageCost { get; set; }
        public double TotalInterestPayable { get; set; }
    }
}
