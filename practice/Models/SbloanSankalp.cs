using System;
using System.Collections.Generic;

#nullable disable

namespace practice.Models
{
    public partial class SbloanSankalp
    {
        public int LoanId { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public decimal AccountNumber { get; set; }
        public decimal Rate { get; set; }
        public decimal Paid { get; set; }
        public string Type { get; set; }
    }
}
