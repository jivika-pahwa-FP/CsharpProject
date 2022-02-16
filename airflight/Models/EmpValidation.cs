using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace airflight{
    public class EmpValidation{

        [Key]
        [DisplayName("Employee ID")]
        public int Empid {get;set;}

        [Required(ErrorMessage ="please enter your name")]
        public string EmpName {get;set;}

        [Range(5000,45000,ErrorMessage ="salary should be within 5k - 45k")]
        public float salary {get;set;}

        [DataType(DataType.DateTime)]
        [DisplayName("Date Of Joining")]
        public DateTime doj {get;set;}

        
        [Required(ErrorMessage ="Enter a Email ID")]
        [DataType(DataType.EmailAddress,ErrorMessage ="Enter valid email ID")]
        public string Email {get;set;}

        [Required]
        public string password {get;set;}
        
        [Compare("password",ErrorMessage ="Password do not match")]
        public string Comparepassword {get;set;}

        public static List<EmpValidation> emp = new List<EmpValidation>();

        public List<EmpValidation> getallEmp(){
            return emp;
        }

    }
}