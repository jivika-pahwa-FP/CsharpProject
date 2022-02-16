using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;

#nullable disable

namespace firstapi.Models
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

        private readonly IWebHostEnvironment webHostEnvironment;
        public StudentTable(){}
        public StudentTable(IWebHostEnvironment _webHostEnvironment){
             webHostEnvironment = _webHostEnvironment;
        }
        
        public List<StudentTable> getAllData(){
            using(var db = new DatabaseTrainingContext()){
                List<StudentTable> data = db.StudentTables.ToList();
                return data;
            }
        }
        public StudentTable GetById(int id){
                using(var db = new DatabaseTrainingContext()){
                    StudentTable obj = db.StudentTables.Find(id);
                    return obj;
                }
            }

            public StudentTable AddStudent(StudentTable obj){
                using(var db = new DatabaseTrainingContext()){
                    var std = db.StudentTables.Add(obj);
                    db.SaveChanges();
                    return obj;
            } 
         }

           public StudentTable UpdateStudent(int id,StudentTable obj){
               System.Console.WriteLine("inside update.....");
               
                using(var db = new DatabaseTrainingContext()){
                    try{
                    System.Console.WriteLine("try iiiii");
                    var std =  db.StudentTables.Update(obj);
                    System.Console.WriteLine("std :: "+std);
                    db.SaveChanges();
                    System.Console.WriteLine("tryy is here");
                    }
                    catch(Exception){}
                    finally{
                        System.Console.WriteLine("in finally");
                    }
                    return obj;
            } 
         }

          public StudentTable DeleteStudent(int id){
             using(var db = new DatabaseTrainingContext()){
                    var std = db.StudentTables.Find(id);
                    db.StudentTables.Remove(std);
                    db.SaveChanges();
                    return std;
            } 
        }

        public StudentTable Login(StudentTable obj){
            using(var db = new DatabaseTrainingContext()){
                    var stdID = db.StudentTables.Find(obj.Id);
                    var stdPass  = db.StudentTables.Where(x=> x.Password == obj.Password).FirstOrDefault();
                    if(stdID != null && stdPass != null ){
                        return obj;
                    }else{
                        return null;
                    }
            }
        }

        public Student Upload(Student obj){
            using(var db = new DatabaseTrainingContext()){
                string filename = null;
                if(obj.FileUpload != null){
                    string uploadFolder = Path.Combine(webHostEnvironment.WebRootPath,"image");
                    filename = obj.FileUpload.FileName;
                    string filepath = Path.Combine(uploadFolder,filename);
                    System.Console.WriteLine(filepath);
                    var filestream = new FileStream(filepath,FileMode.Create);
                    obj.FileUpload.CopyTo(filestream);
                    
                    StudentTable std = new StudentTable();
                    std.FileUpload = "~/image/"+obj.Id+filename;

                    System.Console.WriteLine(std.FileUpload);
                    db.StudentTables.Update(std);
                    db.SaveChanges();
                    
                }
                return obj;
            }
        }
    }
 
    
}
