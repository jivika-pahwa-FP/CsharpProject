﻿using System;
using System.Collections.Generic;

#nullable disable

namespace practiceapi.Models
{
    public partial class Bookk
    {
        public int Bookid { get; set; }
        public string Bookname { get; set; }
        public string Booktype { get; set; }
        public int? Quantity { get; set; }
        public int? Price { get; set; }
    }
}
