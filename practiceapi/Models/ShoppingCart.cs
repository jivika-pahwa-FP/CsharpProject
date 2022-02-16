using System;
using System.Collections.Generic;

#nullable disable

namespace practiceapi.Models
{
    public partial class ShoppingCart
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int? Qty { get; set; }
        public int? Price { get; set; }
    }
}
