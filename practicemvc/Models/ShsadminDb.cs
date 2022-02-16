using System;
using System.Collections.Generic;

#nullable disable

namespace practicemvc.Models
{
    public partial class ShsadminDb
    {
        public string AdminId { get; set; }
        public string AdminName { get; set; }
        public int AdminNumber { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPassword { get; set; }
    }
}
