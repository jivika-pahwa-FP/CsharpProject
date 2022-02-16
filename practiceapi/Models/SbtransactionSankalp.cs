using System;
using System.Collections.Generic;

#nullable disable

namespace practiceapi.Models
{
    public partial class SbtransactionSankalp
    {
        public int TransactionId { get; set; }
        public DateTime Date { get; set; }
        public int AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
    }
}
