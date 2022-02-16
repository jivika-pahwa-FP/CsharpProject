using System;
using System.Collections.Generic;

#nullable disable

namespace practiceapi.Models
{
    public partial class SbaccountSankalp
    {
        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Ifsc { get; set; }
        public decimal Balance { get; set; }
        public decimal CreditScore { get; set; }
        public string Password { get; set; }
    }
}
