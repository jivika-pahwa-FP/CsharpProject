using System;
using System.Collections.Generic;

#nullable disable

namespace practicemvc.Models
{
    public partial class ShsordersDb
    {
        public int OrderId { get; set; }
        public string CustId { get; set; }
        public string ProdId { get; set; }
        public string SellerId { get; set; }
        public string ProdName { get; set; }
        public int OrderPrice { get; set; }
    }
}
