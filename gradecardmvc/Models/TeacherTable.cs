using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace gradecardmvc.Models{

    public class TeacherTable{
        
        [Key]
        [DisplayName("Faculty ID")]
        [Required(ErrorMessage ="Please Enter Faculty ID")]
        public int Id { get; set; }
        
        [DisplayName("Faculty Name")]
        [Required(ErrorMessage ="Please Enter Faculty ID")]
        public string Name { get; set; }
        
        [DisplayName("Faculty Password")]
        [Required(ErrorMessage ="Please Enter Faculty Password")]
        public string Password { get; set; }
        
    }

}