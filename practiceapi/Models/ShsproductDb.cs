using System;
using System.Collections.Generic;

#nullable disable

namespace practiceapi.Models
{
    public partial class ShsproductDb
    {
        public string ProdId { get; set; }
        public string ProdName { get; set; }
        public string ProdType { get; set; }
        public int ProdPrice { get; set; }
        public string SellerId { get; set; }
    }
}
