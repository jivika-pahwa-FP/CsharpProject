﻿using System;
using System.Collections.Generic;

#nullable disable

namespace practice.Models
{
    public partial class AviSbaccount
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public double CurrentBalance { get; set; }
    }
}
