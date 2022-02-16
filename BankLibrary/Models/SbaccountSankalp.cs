using System;
using System.Collections.Generic;

#nullable disable

namespace BankLibrary.Models
{
    public partial class SbaccountSankalp
    {
        public decimal AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CurrentBalance { get; set; }
    }
}
