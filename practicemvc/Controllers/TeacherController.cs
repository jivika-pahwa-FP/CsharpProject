using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practicemvc.Models;

namespace practicemvc{
    public class TeacherController : Controller{

        DatabaseTrainingContext db = new DatabaseTrainingContext();
        TeacherTable table = new TeacherTable();
        
            [HttpGet]
            public IActionResult getAllData(){
                return View(db.TeacherTables.ToList());
            }

            [HttpGet]
            public IActionResult getDetails(int id){
                TeacherTable obj = db.TeacherTables.Find(id);
                return View(obj);
            }

            [HttpGet]
            public IActionResult CreateTeacher(){
                var id = db.TeacherTables.OrderByDescending(x=> x.Id).FirstOrDefault().Id;
                id = ++id;
                ViewBag.teacherId = id;
                return View();
            }

            [HttpPost]
            public IActionResult CreateTeacher(TeacherTable obj){
                db.TeacherTables.Add(obj);
                db.SaveChanges();
                return RedirectToAction("getAllData");
            }

            
            [HttpGet]
            public IActionResult EditDetails(int id){
                TeacherTable obj = db.TeacherTables.Find(id);
                return View(obj);
            }

            
            [HttpPost]
            public IActionResult EditDetails(TeacherTable obj){
                db.TeacherTables.Update(obj);
                db.SaveChanges();
                return RedirectToAction("getAllData");
            }

            [HttpGet]
            public IActionResult Delete(int id){
                TeacherTable obj = db.TeacherTables.Find(id);
                return View(obj);
            }

            [HttpPost]
            [ActionName("Delete")]
            public IActionResult DeleteData(TeacherTable obj){
                db.TeacherTables.Remove(obj);
                db.SaveChanges();
                return RedirectToAction("getAllData");            }
    }
}

