﻿using System;
using System.Collections.Generic;

#nullable disable

namespace mvcefproject.Models
{
    public partial class RaviSbtransaction
    {
        public int TransactionId { get; set; }
        public int? AccountNo { get; set; }
        public string TransactionType { get; set; }
        public DateTime? TransactionDate { get; set; }
    }
}
