using System;
using System.Collections.Generic;

#nullable disable

namespace firstapi.Models
{
    public partial class Todolist
    {
        public int ListId { get; set; }
        public string TodoList1 { get; set; }
        public byte[] Status { get; set; }
    }
}
