using Microsoft.AspNetCore.Mvc;
using airflight.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System;

namespace airflight.Controllers
{
    public class PracticeController : Controller
    {
        
       [Route("[controller]/getData")]
        public IActionResult getData(){
            using(var db = new DatabaseTrainingContext()){
                var data = db.JivikaSbtransactions.ToList();
                return View(data);
            }
        }

        
       [Route("[controller]/ID/{Id}")]
        public string Index(int Id){
            using(var db = new DatabaseTrainingContext()){
                JivikaSbtransaction jivika = new JivikaSbtransaction();
                var data = db.JivikaSbtransactions.Find(Id);
                if(data != null){
                return jivika.ToString(data);
                }
                else{
                     return "Oopss ID not found  : "+Id;
                }
            }
        }

        public IActionResult setCookie(){

            CookieOptions cookieOptions = new CookieOptions();            
            HttpContext.Response.Cookies.Append("first_request", DateTime.Now.ToString(), cookieOptions);
            HttpContext.Response.Cookies.Append("myname","Jivika",cookieOptions);

            ViewBag.Firstcookie = HttpContext.Request.Cookies["first_request"];
            ViewBag.Secondcookie = HttpContext.Request.Cookies["myname"];
            return View();
        }

    }
}