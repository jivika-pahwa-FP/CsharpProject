using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practiceapi.Models;

namespace practiceapi.Controllers{

    
    [ApiController]
    [Route("api/[controller]")]
    public class PracticeController : ControllerBase{

        [HttpGet]
        [Route("getAll")]
        public ActionResult<List<TeacherTable>> getAllData(){
            using(var db = new DatabaseTrainingContext()){
                var data = db.TeacherTables.ToList();
                return Ok(data);
            }
        }

        [HttpGet]
        [Route("getByID/{id}")]
        public ActionResult<TeacherTable> getById(int id){
            using(var db = new DatabaseTrainingContext()){
                var data = db.TeacherTables.Find(id);
                return Ok(data);
            }
        }

        [HttpPost]
        [Route("addData")]
        public ActionResult<TeacherTable> AddTeacher(TeacherTable obj){
            using (var db = new DatabaseTrainingContext()){
                db.TeacherTables.Add(obj);
                db.SaveChanges();
                return Ok();
            }
        }

        [HttpPut]
        [Route("EditData/{id}")]
        public ActionResult<TeacherTable> EditTeacher(int id,TeacherTable obj){
            using (var db = new DatabaseTrainingContext()){
                db.TeacherTables.Update(obj);
                db.SaveChanges();
                return Ok();
            }
        }

        [HttpDelete]
        [Route("DeleteData/{id}")]
        public ActionResult<TeacherTable> DeleteTeacher(int id){
            using (var db = new DatabaseTrainingContext()){
                var obj = db.TeacherTables.Find(id);
                db.TeacherTables.Remove(obj);
                db.SaveChanges();
                return Ok();
            }
        }
        
    }
}