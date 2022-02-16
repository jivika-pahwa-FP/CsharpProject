using System;
using System.Collections.Generic;

#nullable disable

namespace practiceapi.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string Bookname { get; set; }
        public double Price { get; set; }
    }
}
