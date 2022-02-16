﻿using System;
using System.Collections.Generic;

#nullable disable

namespace practice.Models
{
    public partial class SarwatSbtransaction
    {
        public int TransactionId { get; set; }
        public DateTime? TransactionDate { get; set; }
        public int? AccountNumber { get; set; }
        public decimal? Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
