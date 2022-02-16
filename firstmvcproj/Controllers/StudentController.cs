using Microsoft.AspNetCore.Mvc;
using firstmvcproj.Models;
using System.Collections.Generic;
using System.Linq;

namespace firstmvcproj.Controllers
{
    public class StudentController : Controller
    {
      static List<Stu> list = Stu.GetAllDetails();
        public IActionResult Sample(){

            ViewData["age"] = 23;
            ViewBag.CompanyName = "Fareportal";
            return View();
        }

        public IActionResult GetStudentDetails(){

            return View(list);
        }
        
        [HttpGet]
        public IActionResult AddnewStudent(){
            return View();
        }

        [HttpPost]
        public IActionResult AddnewStudent(Stu s){
            list.Add(s);
            return RedirectToAction("GetStudentDetails");
        }

        public IActionResult knowmore(int id){
            Stu obj = list.Where(i => i.stud_id == id).FirstOrDefault();
            return View(obj);
        }
        public IActionResult delete(int id){
            Stu obj = list.Where(i => i.stud_id == id).FirstOrDefault();
            list.Remove(obj);
            return RedirectToAction("GetStudentDetails");
        }

    }   
}
