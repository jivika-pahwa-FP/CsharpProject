using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using airflight.Models;

namespace airflight.Controllers
{
    public class StudentController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public StudentController(IHttpContextAccessor httpContextAccessor){
                _httpContextAccessor = httpContextAccessor;
        }

        public  IActionResult AddNumber(){
            return View();
        }

        [HttpPost]
        public  IActionResult AddNumber(IFormCollection f){
            // int a = Convert.ToInt32(f["first"]);
            // int b = Convert.ToInt32(f["second"]);

            int a = Convert.ToInt32(Request.Form["first"]);
            int b = Convert.ToInt32(Request.Form["second"]);
            int c = a+b;
            ViewBag.result = c;
            HttpContext.Session.SetString("result",c.ToString());
            return View();
        }

        [HttpGet]
        public IActionResult Login(){
                return View();
        }

        [HttpPost]
        public IActionResult Login(User obj){
            CookieOptions option = new CookieOptions();
            if(obj.username == "admin" && obj.password == "123"){
                Response.Cookies.Append("username",obj.username,option);
                return RedirectToAction("Dashboard");
            }
            else
                return View();
        }

        public IActionResult Dashboard(){
            string username = _httpContextAccessor.HttpContext.Request.Cookies["username"]; 
            ViewBag.name = username;
            return View();
        }

        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }
    }
}