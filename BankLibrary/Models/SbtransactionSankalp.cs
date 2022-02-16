using System;
using System.Collections.Generic;

#nullable disable

namespace BankLibrary.Models
{
    public partial class SbtransactionSankalp
    {
        public decimal TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal AccountNumber { get; set; }
        public decimal Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
