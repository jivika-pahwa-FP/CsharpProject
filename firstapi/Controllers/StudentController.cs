using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstapi.Models;
using Microsoft.EntityFrameworkCore;

namespace firstapi.Controllers
{   
    
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase{

        //Student std = new Student();
        StudentTable student = new StudentTable();

        // [Route("getData")]
        // public async Task<ActionResult<List<Student>>> getData(){
        //         var data =  std.getData().ToList();
        //         return Ok(data);
            
        // }
        
       [Route("getAllData")]
        [HttpGet]
        public IEnumerable<StudentTable> Get(){
            return student.getAllData();
        }

        [Route("Edit/{id}")]
        [HttpGet()]
        public StudentTable GetById(int id){
            return student.GetById(id);
        }

        [Route("AddData")]
        [HttpPost]
        public StudentTable AddStudent(StudentTable obj){
             student.AddStudent(obj);
             return obj;
        }

        
        [Route("Update/{id}")]
        [HttpPut]
        public StudentTable Put(int id,StudentTable obj){
            System.Console.WriteLine("inside block");
            student.UpdateStudent(id,obj);
            System.Console.WriteLine(obj.FileUpload);

            return obj;
        }

        // [Route("Delete/{id}")]
        // [HttpDelete]
        // public StudentTable DeleteStudent(int id){
        //      StudentTable data = student.DeleteStudent(id);
        //      return data;
        // }

        [Route("Delete/{id}")]
        [HttpDelete]
        public StudentTable DeleteStudent(int id){
             StudentTable data = student.DeleteStudent(id);
             return data;
        }

        [Route("CheckLogin")]
        [HttpPost]
        public StudentTable Login(StudentTable obj){
             StudentTable data = student.Login(obj);
             return data;
        }

        [Route("uploadAssignment/{id}")]
        [HttpPut]
        public Student upload(int id,Student obj){
            System.Console.WriteLine("Upload block");
            student.Upload(obj);
            return obj;
        }

    }
}