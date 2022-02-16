using System;
using System.Collections.Generic;

#nullable disable

namespace practicemvc.Models
{
    public partial class ShoppingCart
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int? Qty { get; set; }
        public int? Price { get; set; }
    }
}
