using Microsoft.AspNetCore.Http;

namespace gradecardmvc.Models
{
    public class Student
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Subject1 { get; set; }
        public int? Subject2 { get; set; }
        public int? Subject3 { get; set; }
        public double? Percentage { get; set; }
        public string Grade { get; set; }
        public string Password { get; set; }
        public IFormFile FileUpload { get; set; }
    }
}