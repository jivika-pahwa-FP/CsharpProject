using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using airflight.Models;
using Microsoft.AspNetCore.Http;

namespace airflight.Controllers
{

    public class AdminController : Controller
    {
        
    private readonly DatabaseTrainingContext db;

    public AdminController(DatabaseTrainingContext _db){
        db = _db;
    }   

        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public IActionResult Login(User obj){

            if(obj.username == "admin" && obj.password == "admin"){
                HttpContext.Session.SetString("username",obj.username);
                return RedirectToAction("getallFlight");
            }
            else
            return View();
        }

        public IActionResult Logout(){
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        public IActionResult getallFlight(){
            ViewBag.username = HttpContext.Session.GetString("username");
            return View(db.FlightDetails.ToList());
        }

        public IActionResult getallRoute(){
            ViewBag.username = HttpContext.Session.GetString("username");
            return View(db.RouteDetails.ToList());
        }

        [HttpGet]
        public IActionResult CreateFlight(){
            return View();
        }

        [HttpPost]
        public IActionResult CreateFlight(FlightDetail f){
            db.FlightDetails.Add(f);
            db.SaveChanges();
            return RedirectToAction("getallFlight");
        }

        
        [HttpGet]
        public IActionResult CreateRoute(){
            return View();
        }

        [HttpPost]
        public IActionResult CreateRoute(RouteDetail r){
            db.RouteDetails.Add(r);
            db.SaveChanges();
            return RedirectToAction("getallRoute");
        }

        public IActionResult DetailFlight(int id){
            FlightDetail obj = db.FlightDetails.Find(id);
            return View(obj);
        }

        public IActionResult DetailRoute(int id){
            RouteDetail obj = db.RouteDetails.Find(id);
            return View(obj);
        }

        [HttpGet]
        public IActionResult EditFlight(int id){
            FlightDetail obj = db.FlightDetails.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult EditFlight(FlightDetail f){
            db.FlightDetails.Update(f);
            db.SaveChanges();
            return RedirectToAction("getallFlight");
        }


        [HttpGet]
        public IActionResult EditRoute(int id){
            RouteDetail obj = db.RouteDetails.Find(id);
            return View(obj);
        }

        [HttpPost]
        public IActionResult EditRoute(RouteDetail f){
            db.RouteDetails.Update(f);
            db.SaveChanges();
            return RedirectToAction("getallRoute");
        }

        [HttpGet]
        public IActionResult DeleteFlight(int id){
            FlightDetail obj = db.FlightDetails.Find(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("DeleteFlight")]
        public IActionResult DeleteFlightConfirmed(int id){
            FlightDetail obj = db.FlightDetails.Find(id);
            db.FlightDetails.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("getallFlight");
        }

        [HttpGet]
        public IActionResult DeleteRoute(int id){
            RouteDetail obj = db.RouteDetails.Find(id);
            return View(obj);
        }

        [HttpPost]
        [ActionName("DeleteRoute")]
        public IActionResult DeleteRouteConfirmed(int id){
            RouteDetail obj = db.RouteDetails.Find(id);
            db.RouteDetails.Remove(obj);
            db.SaveChanges();
            return RedirectToAction("getallRoute");
        }

    }
}