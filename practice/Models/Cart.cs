using System;
using System.Collections.Generic;

#nullable disable

namespace practice.Models
{
    public partial class Cart
    {
        public int Bookid { get; set; }
        public string Bookname { get; set; }
        public string Booktype { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
    }
}
