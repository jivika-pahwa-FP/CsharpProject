using System;
using System.Collections.Generic;

#nullable disable

namespace practiceapi.Models
{
    public partial class StudentTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Subject1 { get; set; }
        public int? Subject2 { get; set; }
        public int? Subject3 { get; set; }
        public double? Percentage { get; set; }
        public string Grade { get; set; }
        public string Password { get; set; }
        public string FileUpload { get; set; }
    }
}
