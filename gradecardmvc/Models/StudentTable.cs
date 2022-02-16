using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace gradecardmvc.Models{

    public class StudentTable{

            
        [Key]
        [DisplayName("Student ID")]
        [Required(ErrorMessage ="Please Enter Student ID")]
        public int Id { get; set; }
        
        [DisplayName("Student Password")]
        [Required(ErrorMessage ="Please Enter Student Password")]
        public string Password { get; set; }
        
        [DisplayName("Student Name")]
        [Required(ErrorMessage ="please Enter Student Name")]
        public string Name { get; set; }

        
        [DisplayName("Internal Marks")]
        [Range(1,100,ErrorMessage ="Enter marks within 1-100")]
        public int? Subject1 { get; set; }
        
        
        [DisplayName("External Marks")]
        [Range(1,100,ErrorMessage ="Enter marks within 1-100")]
        public int? Subject2 { get; set; }
        
        
        [DisplayName("Assignment Marks")]
        [Range(1,100,ErrorMessage ="Enter marks within 1-100")]
        public int? Subject3 { get; set; }
        public double? Percentage { get; set; }

        public string Grade { get; set; }
        
        [DisplayName(" Upload your Assignment")]
        public string FileUpload { get; set; }

    }
}