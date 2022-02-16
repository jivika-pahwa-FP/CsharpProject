using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvcefproject.Models;

namespace mvcefproject.Controllers
{
    public class CrudController : Controller
    {
        
       private readonly DatabaseTrainingContext db;

       PracticeTable table = new PracticeTable();
        public CrudController(DatabaseTrainingContext _db){
            db = _db;
        }

        public IActionResult Index(){
            return View();
        }
        public IActionResult getAll(){
            return View(db.PracticeTables.ToList());
        }

        [HttpGet]
        public IActionResult Create(){

            return View();
        }

        [HttpPost]
        public IActionResult Create(PracticeTable obj){
            db.PracticeTables.Add(obj);
            db.SaveChanges();
            return RedirectToAction("getAll");
        }

        [HttpGet]
        public IActionResult Edit(int id){
            PracticeTable obj = db.PracticeTables.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult Edit(PracticeTable obj){
            db.PracticeTables.Update(obj);
            db.SaveChanges();
            return RedirectToAction("getAll");
        }
        
        [HttpGet]
        public IActionResult Details(int id){
            PracticeTable obj = db.PracticeTables.Find(id);
            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int id){
            PracticeTable obj = db.PracticeTables.Find(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id){
            PracticeTable obj = db.PracticeTables.Find(id);
            db.PracticeTables.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("getAll");
        }


    }
}