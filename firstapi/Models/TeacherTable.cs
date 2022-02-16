using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace firstapi.Models
{
    public partial class TeacherTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

         public List<TeacherTable> getAllData(){
            using(var db = new DatabaseTrainingContext()){
                List<TeacherTable> data = db.TeacherTables.ToList();
                return data;
            }
        }
        public TeacherTable GetById(int id){
                using(var db = new DatabaseTrainingContext()){
                    TeacherTable obj = db.TeacherTables.Find(id);
                    return obj;
                }
            }

            public TeacherTable AddFaculty(TeacherTable obj){
                using(var db = new DatabaseTrainingContext()){
                    var std = db.TeacherTables.Add(obj);
                    db.SaveChanges();
                    return obj;
            } 
         }

           public TeacherTable UpdateFaculty(TeacherTable obj){
                using(var db = new DatabaseTrainingContext()){
                    var std = db.TeacherTables.Update(obj);
                    db.SaveChanges();
                    return obj;
            } 
         }

          public TeacherTable DeleteFaculty(int id){
             using(var db = new DatabaseTrainingContext()){
                    var std = db.TeacherTables.Find(id);
                    db.TeacherTables.Remove(std);
                    db.SaveChanges();
                    return std;
            } 
        }

        public TeacherTable Login(TeacherTable obj){
            using(var db = new DatabaseTrainingContext()){
                    var stdID = db.TeacherTables.Find(obj.Id);
                    var stdPass  = db.TeacherTables.Where(x=> x.Password == obj.Password).FirstOrDefault();
                    if(stdID != null && stdPass != null ){
                        return obj;
                    }else{
                        return null;
                    }
            }
        }
    }
}
