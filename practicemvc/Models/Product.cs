using System;
using System.Collections.Generic;

#nullable disable

namespace practicemvc.Models
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
    }
}
