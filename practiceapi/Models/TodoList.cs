using System;
using System.Collections.Generic;

#nullable disable

namespace practiceapi.Models
{
    public partial class TodoList
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Complete { get; set; }
    }
}
