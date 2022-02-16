using System;
using System.Collections.Generic;

#nullable disable

namespace practicemvc.Models
{
    public partial class ZtoDoList
    {
        public int EventId { get; set; }
        public int UserId { get; set; }
        public string EventTitle { get; set; }
        public DateTime? EventCreated { get; set; }
        public string EventDescription { get; set; }
    }
}
