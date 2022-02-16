using System;
using System.Collections.Generic;

#nullable disable

namespace practice.Models
{
    public partial class Pizza
    {
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public int? PizzaQuantity { get; set; }
        public int? PizzaPrice { get; set; }
    }
}
