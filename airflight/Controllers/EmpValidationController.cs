using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using airflight.Models;
using Microsoft.AspNetCore.Http;

namespace airflight.Controllers {

        public class EmpValidationController : Controller {
            EmpValidation obj = new EmpValidation();
            static List<EmpValidation> emp = new List<EmpValidation>();
    
            public IActionResult getallEmp(){
                emp = obj.getallEmp();
                return View(emp);
            }

            [HttpGet]
            public IActionResult Create(){
                return View();
            }
            
            [HttpPost]
            public IActionResult Create(EmpValidation e){
                if(ModelState.IsValid){
                emp.Add(e);
                return RedirectToAction("getallEmp");
                }
                else return View();
            }

        }
    
}