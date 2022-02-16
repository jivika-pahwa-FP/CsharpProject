
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace firstapi{

    public class Student{
            
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Subject1 { get; set; }
        public int? Subject2 { get; set; }
        public int? Subject3 { get; set; }
        public double? Percentage { get; set; }
        public string Grade { get; set; }
        public string Password { get; set; }
        public IFormFile FileUpload { get; set; }


    //        public static List<Student> list = new List<Student>();
           
    //        public Student(){

    //        }

    //        public Student(int Id,string name,int age){
    //            this.Id = Id;
    //            this.name = name;
    //            this.age = age;
    //        }
    //         public List<Student> getData(){
    //             list.Add(new Student(1,"Jivika",23));
    //             list.Add(new Student(2,"Pooja",23));
    //             list.Add(new Student(3,"Ashish",23));
    //             return list;
    //         }

    //         public Student GetById(int Id){
    //             list = getData();
    //             Student obj = list.Where(x => x.Id==Id).FirstOrDefault();
    //             return obj;
    //         }

    //         public void AddStudent(Student obj){
    //             list.Add(obj);
    //         }

    //         public Student DeleteStudent(int Id){
    //             Student data = GetById(Id);
    //             list.Remove(data);
    //             return data;
    //         }
    // 
    }
}