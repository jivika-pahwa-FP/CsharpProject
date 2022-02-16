using System;
using System.Collections.Generic;

#nullable disable

namespace practicemvc.Models
{
    public partial class Watchlist
    {
        public int RecordId { get; set; }
        public int CustomerId { get; set; }
        public string Stock { get; set; }
    }
}
