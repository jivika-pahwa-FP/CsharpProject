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
    public class FacultyController : ControllerBase
    {

        StudentTable student = new StudentTable();
        TeacherTable faculty = new TeacherTable();

        [Route("getFacultyData")]
        [HttpGet]
        public  IEnumerable<TeacherTable> getFacultyData(){
                List<TeacherTable> list = new List<TeacherTable>();
                list = faculty.getAllData();
                return list;
        }

        
        [Route("FacultyAddData")]
        [HttpPost]
        public TeacherTable AddFaculty(TeacherTable obj){
             faculty.AddFaculty(obj);
             return obj;
        }

        [Route("FacultyEdit/{id}")]
        [HttpGet()]
        public TeacherTable GetByFacultyId(int id){
            return faculty.GetById(id);
        }

        [Route("FacultyUpdate/{id}")]
        [HttpPut]
        public TeacherTable UpdateFaculty(int id,TeacherTable obj){
            faculty.UpdateFaculty(obj);
            return obj;
        }

        [Route("FacultyDelete/{id}")]
        [HttpDelete]
        public TeacherTable DeleteFaculty(int id){
             TeacherTable data = faculty.DeleteFaculty(id);
             return data;
        }

        [Route("CheckLogin")]
        [HttpPost]
        public TeacherTable Login(TeacherTable obj){
             TeacherTable data = faculty.Login(obj);
             return data;
        }


        //    Student API      *************************************************


        [Route("getStudentData")]
        [HttpGet]
        public  IEnumerable<StudentTable> getStudentData(){
                List<StudentTable> list = new List<StudentTable>();
                list = student.getAllData();
                return list;
        }
        
        
        [Route("StudentAddData")]
        [HttpPost]
        public StudentTable AddStudent(StudentTable obj){
             student.AddStudent(obj);
             return obj;
        }

        [Route("StudentEdit/{id}")]
        [HttpGet]
        public StudentTable GetById(int id){
            return student.GetById(id);
        }

        
        [Route("StudentUpdate/{id}")]
        [HttpPut]
        public StudentTable UpdateStudent(int id,StudentTable obj){
            student.UpdateStudent(id,obj);
            return obj;
        }

        [Route("StudentDelete/{id}")]
        [HttpDelete]
        public StudentTable DeleteStudent(int id){
             StudentTable data = student.DeleteStudent(id);
             return data;
        }

    }
}